﻿using Ko.Navigation.CefGlue.Tests.Infra;
using Tests.Universal.NavigationTests;
using Xunit;

namespace Ko.Navigation.CefGlue.Tests
{
    [Collection("Cef Window Integrated")]
    public class DoubleNavigation_Ko_Cef_Tests : DoubleNavigationTests
    {
        public DoubleNavigation_Ko_Cef_Tests(CefGlueKoContext context) : base(context)
        {
        }
    }
}
