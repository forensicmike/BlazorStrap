﻿using Microsoft.AspNetCore.Components;
using BlazorStrap.Util;
using BlazorComponentUtilities;
using System;

namespace BlazorStrap
{
    public class CodeBSCarouselCaption : BootstrapComponentBase
    {
        protected string classname =>
        new CssBuilder("carousel-caption d-none d-md-block")
        .AddClass(Class)
        .Build();

        [Parameter] protected string Class { get; set; }
        [Parameter] protected string CaptionText { get; set; }
        [Parameter] protected string HeaderText { get; set; }
    }
}
