// Copyright (c) Forged WoW LLC <https://github.com/ForgedWoW/WrathForgedCore>
// Licensed under GPL-3.0 license. See <https://github.com/ForgedWoW/WrathForgedCore/blob/master/LICENSE> for full information.
using WrathForged.Common.Time;

namespace WrathForged.Instance.Server.Maps;
public class MapConst
{
    public const int CENTER_GRID_CELL_ID = MAX_CELLS * MAX_GRIDS / 2;
    public const float CENTER_GRID_CELL_OFFSET = SIZEOF_CELLS / 2;
    public const int CENTER_GRID_ID = MAX_GRIDS / 2;
    public const float CENTER_GRID_OFFSET = SIZEOF_GRIDS / 2;
    public const float DEFAULT_COLLESION_HEIGHT = 2.03128f;
    public const float DEFAULT_HEIGHT_SEARCH = 50.0f;
    public const float GROUND_HEIGHT_TOLERANCE = 0.05f;
    public const float INVALID_HEIGHT = -100000.0f;
    public const uint INVALID_ZONE = 0xFFFFFFFF;

    //Liquid
    public const float LIQUID_TILE_SIZE = 533.333f / 128.0f;

    public const uint MAP_AREA_MAGIC = 0x41455241;

    public const float MAP_HALF_SIZE = MAP_SIZE / 2;

    //"AREA";
    public const uint MAP_HEIGHT_MAGIC = 0x5447484D;

    //"MHGT";
    public const uint MAP_LIQUID_MAGIC = 0x51494C4D;

    public const uint MAP_MAGIC = 0x5350414D;

    public const int MAP_RESOLUTION = 128;

    public const float MAP_SIZE = SIZEOF_GRIDS * MAX_GRIDS;

    //"MAPS";
    public const uint MAP_VERSION_MAGIC = 10;

    // Most common value in dbc
    public const uint MAP_VERSION_MAGIC_2 = 0x302E3276;

    //Cells
    public const int MAX_CELLS = 8;

    public const uint MAX_DUNGEON_ENCOUNTERS_PER_BOSS = 4;

    public const float MAX_FALL_DISTANCE = 250000.0f;

    //Grids
    public const int MAX_GRIDS = 64;

    public const uint MAX_GROUP_SIZE = 5;
    public const float MAX_HEIGHT = 100000.0f;
    public const uint MAX_RAID_SIZE = 40;
    public const uint MAX_RAID_SUB_GROUPS = MAX_RAID_SIZE / MAX_GROUP_SIZE;
    public const int MIN_GRID_DELAY = TimeUtil.MINUTE * TimeUtil.IN_MILLISECONDS;
    public const int MIN_MAP_UPDATE_DELAY = 1;
    public const uint MMAP_MAGIC = 0x4D4D4150;

    // 'MMAP'
    public const int MMAP_VERSION = 15;

    public const uint RAID_MARKERS_COUNT = 8;
    public const uint READYCHECK_DURATION = 35000;
    public const float SIZEOF_CELLS = SIZEOF_GRIDS / MAX_CELLS;
    public const float SIZEOF_GRIDS = 533.33333f;
    public const uint TARGET_ICONS_COUNT = 8;
    public const int TOTAL_CELLS_PER_MAP = MAX_GRIDS * MAX_CELLS;
    public const float VMAP_INVALID_HEIGHT_VALUE = -200000.0f;

    //"v2.0"; // Hack for some different extractors using v2.0 header
    //"MLIQ";
    public const string V_MAP_MAGIC = "VMAP_4.B";

    public const float Z_OFFSET_FIND_HEIGHT = 0.5f;
}