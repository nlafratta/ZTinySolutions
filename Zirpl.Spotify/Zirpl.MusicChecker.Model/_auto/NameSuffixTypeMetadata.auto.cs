﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model
{
    public partial class NameSuffixTypeMetadata : DictionaryEntityBaseMetadataBase
    {
        public const string Name_Name = "Name";
		public const bool Name_IsRequired = true;
		public const bool Name_IsMaxLength = false;
        public const int Name_MinLength = 1;
		public const int Name_MaxLength = 100;

	}
}
