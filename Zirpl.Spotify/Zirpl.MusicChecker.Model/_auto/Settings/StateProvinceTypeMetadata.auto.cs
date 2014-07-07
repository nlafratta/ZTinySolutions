﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Settings
{
    public partial class StateProvinceTypeMetadata : DictionaryEntityBaseMetadataBase
    {
        public const string Name_Name = "Name";
		public const bool Name_IsRequired = true;
		public const bool Name_IsMaxLength = false;
        public const int Name_MinLength = 1;
		public const int Name_MaxLength = 256;

        public const string Abbreviation_Name = "Abbreviation";
		public const bool Abbreviation_IsRequired = true;
		public const bool Abbreviation_IsMaxLength = false;
        public const int Abbreviation_MinLength = 1;
		public const int Abbreviation_MaxLength = 2;

	}
}
