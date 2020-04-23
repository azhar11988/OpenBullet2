﻿using OpenBullet2.Models.BlockParameters;
using RuriLib.Models.Variables;
using System.Linq;

namespace OpenBullet2.Models
{
    public class BlockInfo
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public string ExtraInfo { get; set; }
        public BlockParameter[] Parameters { get; set; }
        public VariableType? ReturnType { get; set; }

        public BlockInstance CreateInstance()
        {
            return new BlockInstance
            {
                Info = this,
                Settings = new BlockSettings
                {
                    Label = Name,
                    Settings = Parameters.Select(p => p.ToBlockSetting()).ToArray()
                }
            };
        }
    }
}