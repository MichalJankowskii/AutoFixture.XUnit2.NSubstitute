﻿namespace Objectivity.AutoFixture.XUnit2.AutoMocking.Core.Customizations
{
    using Common;
    using Ploeh.AutoFixture;

    public class OmitOnRecursionCustomization : ICustomization
    {
        public void Customize(IFixture fixture)
        {
            // Ommit recursion on first level.
            fixture.NotNull(nameof(fixture))
                .Behaviors
                .Add(new OmitOnRecursionBehavior());
        }
    }
}