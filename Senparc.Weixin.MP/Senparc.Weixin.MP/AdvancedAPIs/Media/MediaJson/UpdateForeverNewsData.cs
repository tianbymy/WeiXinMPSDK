﻿/*----------------------------------------------------------------
    Copyright (C) 2015 Senparc
    
    文件名：UpdateForeverNewsData.cs
    文件功能描述：修改永久图文素材需要post的数据
    
    
    创建标识：Senparc - 20150324
----------------------------------------------------------------*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Senparc.Weixin.MP.AdvancedAPIs.GroupMessage;
using Senparc.Weixin.MP.Entities;

namespace Senparc.Weixin.MP.AdvancedAPIs.Media
{
    /// <summary>
    /// 修改永久图文素材需要post的数据
    /// </summary>
    public class UpdateForeverNewsData
    {
        /// <summary>
        /// 要修改的图文消息的id
        /// </summary>
        public string media_id { get; set; }
        /// <summary>
        /// 要更新的文章在图文消息中的位置（多图文消息时，此字段才有意义），第一篇为0
        /// </summary>
        public int index { get; set; }
        /// <summary>
        /// 图文素材
        /// 若新增的是多图文素材，则此处应还有几段articles结构
        /// </summary>
        public NewsModel[] articles { get; set; }
    }
}