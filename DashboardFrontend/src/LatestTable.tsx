import { batch, createMemo, createSignal, For, mergeProps, Show, VoidComponent, JSX } from "solid-js"
import { useRimionship } from "./RimionshipContext"
import { LatestStats } from "./Stats"
import { CC, ColumnDef, ColumnId, displayValue } from "./Utils"

const DefaultColumns = [
  CC('Place', '#'),
  CC('UserId', 'Player'),
  CC('Wealth', 'Wealth'),
  CC('WasShownTimes', 'Stream'),
  CC('MapCount', 'Map'),
  CC('Colonists', 'Colonist'),
  CC('ColonistsNeedTending', 'Injured'),
  CC('MedicalConditions', 'Med Cond'),
  CC('Enemies', 'Enemies'),
  CC('MentalColonists', 'Mental'),
  CC('DownedColonists', 'Downed'),
  CC('Conditions', 'Map Cond'),
  CC('NumRaidsEnemy', 'Raid'),
  CC('NumThreatBigs', 'Thread'),
  CC('Fire', 'Fire'),
  CC('WeaponDps', 'Weapon'),
  CC('Electricity', 'Power'),
  CC('Prisoners', 'Prisoners'),
  CC('Rooms', 'Room'),
  CC('Medicine', 'Med'),
  CC('Food', 'Food'),
  CC('GreatestPopulation', 'Max Pop'),
  CC('Caravans', 'Caravan'),
  CC('WildAnimals', 'Wild Animal'),
  CC('TamedAnimals', 'Tame Animal'),
  CC('Visitors', 'Visitors'),
  CC('Temperature', 'Temp'),
  CC('InGameHours', 'Hours'),
  CC('DamageTakenPawns', 'Dam. Pawn'),
  CC('DamageTakenThings', 'Dam. Thing'),
  CC('DamageDealt', 'Dam. Dealt'),
  CC('ColonistsKilled', 'Casualty'),
  CC('TicksLowColonistMood', 'Quest Mood'),
  CC('TicksIgnoringBloodGod', 'Quest God'),
  CC('AnimalMeatCreated', 'Quest Meat'),
  CC('AmountBloodCleaned', 'Quest Blood'),
  CC('Timestamp', 'Seen Ago')
]

export const LatestTable: VoidComponent<{ sortable?: boolean, columns?: ColumnDef[], width: number }> = (props) => {
  props = mergeProps({ sortable: true, columns: DefaultColumns }, props)
  const { latestStats, users } = useRimionship()
  const [sortKey, setSortKey] = createSignal<ColumnId | undefined>('Place')
  const [sortDir, setSortDir] = createSignal<-1 | 1>(-1)
  const [stopUpdating, setStopUpdating] = createSignal(false)

  const changeSort = (col: ColumnId) => {
    if (!props.sortable)
      return

    if (sortKey() === col) {
      if (sortDir() === 1)
        setSortDir(-1)
      else {
        batch(() => {
          setSortKey(undefined)
          setSortDir(1)
        })
      }
    }
    else {
      batch(() => {
        setSortKey(col)
        setSortDir(1)
      })
    }
  }

  const arrowState = (col: ColumnId, dir: -1 | 1) => {
    const sk = sortKey()
    const isActive = (sk === col && sortDir() === dir)
    return {
      "text-secondary": !isActive,
      "text-light": isActive,
    }
  }

  const sort = (a: any, b: any): number => {
    if (a instanceof Array && a[0] instanceof Date && b instanceof Array && b[0] instanceof Date) {
      return a[0].getTime() - b[0].getTime()
    }

    if (typeof a === 'string' && typeof b === 'string') {
      return a.localeCompare(b)
    }

    if (typeof a === 'number' && typeof b === 'number') {
      return a - b
    }

    console.log('cannot sort', typeof a, typeof b)
    return 0
  }

  const selectColor = (col: ColumnDef) => {
    const sk = sortKey()
    var c = '#000'
    if (col.sortable) {
      if (sk === col.id) {
        if (sortDir() == -1)
          c = '#050'
        else
          c = '#500'
      }
    }
    let res = { 'background-color': c, 'text-align': 'center', 'padding-left': 'inherit' }
    if (col.displayName == 'Spieler') {
      res['text-align'] = 'left'
      res['padding-left'] = '12px'
    }
    if (col.id == 'Prisoners' || col.id == 'DamageDealt') {
      res['border-right'] = '1px solid white'
    }
    return res
  }

  const alignment = (col: ColumnDef) => {
    let res = { 'text-align': 'center', 'padding-left': 'inherit' } as JSX.CSSProperties
    if (col.displayName == 'Spieler') {
      res['text-align'] = 'left'
      res['padding-left'] = '12px'
    }
    if (col.id == 'Prisoners' || col.id == 'DamageDealt') {
      res['border-right'] = '1px solid black'
    }
    return res
  }

  const rowColor = (row: LatestStats) => {
    let u = users[row.UserId]
    return { 'background-color': u.WasBanned ? '#ffb0c0' : u.HasQuit ? '#c0ffc0' : 'white' }
  }

  const widthStyle = () => {
    if (!props.width)
      return {}
    return { 'width': props.width + 'px' }
  }

  const rows = createMemo<LatestStats[]>((prev) => {
    if (stopUpdating())
      return prev ?? latestStats

    const sk = sortKey()
    if (sk === undefined)
      return latestStats

    const sd = sortDir()
    let statsArray = Array.from(latestStats)

    if (sk === 'UserId')
      return statsArray.sort((a, b) => sort(users[b.UserId].UserName, users[a.UserId].UserName) * sd)
    return statsArray.sort((a, b) => sort(b[sk], a[sk]) * sd)
  })

  return <table class="table table-striped table-hover table-stoppable stats" style={widthStyle()} classList={{ "table-secondary": stopUpdating() }}>
    <thead>
      <tr class="table-dark sortable">
        <For each={props.columns}>{(col) =>
          <th onClick={() => changeSort(col.id)} title={col.id} style={selectColor(col)}>
            {col.displayName}
            <Show when={false && col.sortable && props.sortable}>
              <span classList={arrowState(col.id, 1)}>&#9660;</span><span classList={arrowState(col.id, -1)}>&#9650;</span>
            </Show>
          </th>
        }</For>
      </tr>
    </thead>
    <tbody onMouseEnter={() => setStopUpdating(true)} onMouseLeave={() => setStopUpdating(false)}>
      <For each={rows()}>{(row) =>
        <tr style={rowColor(row)}>
          <For each={props.columns}>{(col) => <td style={alignment(col)}>{displayValue(row[col.id], col.id)}</td>}</For>
        </tr>
      }</For>
    </tbody>
  </table>
}
