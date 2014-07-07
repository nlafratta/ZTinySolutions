﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class SystemSettingMetadata : MetadataBase
    {
        public const string Name_Name = "Name";
		public const bool Name_IsRequired = true;
		public const bool Name_IsMaxLength = false;
        public const int Name_MinLength = 1;
		public const int Name_MaxLength = 512;

        public const string Value_Name = "Value";
		public const bool Value_IsRequired = false;
		public const bool Value_IsMaxLength = true;
        public const int Value_MinLength = 0;
		public const int Value_MaxLength = MetadataBase.MaxLength;

	}
}
