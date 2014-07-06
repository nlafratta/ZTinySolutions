﻿using System;
using System.Collections;
using System.Collections.Generic;
using Zirpl.AppEngine.Model;

namespace Zirpl.MusicChecker.Model.Subscriptions
{
    public partial class SubscriptionPeriodType : DictionaryEntityBase<byte, SubscriptionPeriodTypeEnum>
    {
		public override string Name { get; set; }
		public virtual string PluralName { get; set; }
    }
}

