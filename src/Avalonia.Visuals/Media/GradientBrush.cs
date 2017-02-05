// Copyright (c) The Avalonia Project. All rights reserved.
// Licensed under the MIT license. See licence.md file in the project root for full license information.

using System;
using System.Collections.Generic;
using Avalonia.Metadata;

namespace Avalonia.Media
{
    public abstract class GradientBrush : Brush, IGradientBrush
    {
        public static readonly StyledProperty<GradientSpreadMethod> SpreadMethodProperty =
            AvaloniaProperty.Register<GradientBrush, GradientSpreadMethod>(nameof(SpreadMethod));

        public static readonly StyledProperty<List<GradientStop>> GradientStopsProperty =
            AvaloniaProperty.Register<GradientBrush, List<GradientStop>>(nameof(Opacity));

        public GradientBrush()
        {
            this.GradientStops = new List<GradientStop>();
        }

        public GradientSpreadMethod SpreadMethod
        {
            get { return GetValue(SpreadMethodProperty); }
            set { SetValue(SpreadMethodProperty, value); }
        }

        // TODO: We shouldn't be returning a concrete List<> here
        [Content]
        public List<GradientStop> GradientStops
        {
            get { return GetValue(GradientStopsProperty); }
            set { SetValue(GradientStopsProperty, value); }
        }

        IReadOnlyList<GradientStop> IGradientBrush.GradientStops => GradientStops;
    }
}