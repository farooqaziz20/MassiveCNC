﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CNC_Settings 
{
    public static int importBezierLineSegmentsCnt;
    public static bool importResizeSVG;
    public static float importSVGMaxSize;
    public static bool importSVGPathClose;
    public static bool importSVGToMM;
    public static bool importSVGNodesOnly;
    public static bool importSVGGroups;
    internal static double importGCTangentialTurn;
    internal static double machineLimitsHomeX;
    internal static double machineLimitsRangeX;
    internal static double machineLimitsHomeY;
    internal static double machineLimitsRangeY;
    internal static float importGCLineSegmentLength;
    internal static bool importGCLineSegmentEquidistant;
    internal static string importGCHeader;
    internal static bool importUnitGCode;
    internal static bool importUnitmm;
    internal static string importGCFooter;
    internal static int importRepeatCnt;
}
