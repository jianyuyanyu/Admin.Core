﻿namespace ZhonTai.Admin.Tools.Captcha;

/// <summary>
/// 坐标模型
/// </summary>
public class PointModel
{
    /// <summary>
    /// x坐标
    /// </summary>
    public int X { get; set; }

    /// <summary>
    /// y坐标
    /// </summary>
    public int Y { get; set; }

    public PointModel(int x, int y)
    {
        X = x;
        Y = y;
    }
}
