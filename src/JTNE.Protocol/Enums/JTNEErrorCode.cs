﻿using System;
using System.Collections.Generic;
using System.Text;

namespace JTNE.Protocol.Enums
{
    /// <summary>
    /// 错误代码
    /// </summary>
    public enum JTNEErrorCode
    {
        /// <summary>
        /// 开始标识错误
        /// </summary>
        BeginFlagError = 1001,
        /// <summary>
        /// BCC校验错误
        /// </summary>
        BCCCodeError = 1002,
        /// <summary>
        /// 没有标记
        /// <see cref="JTNE.Protocol.Attributes.JTNEFormatterAttribute"/>
        /// </summary>
        GetFormatterAttributeError = 1003,
        /// <summary>
        /// 解析数据体错误
        /// </summary>
        BodiesParseError=1004,
    }
}
