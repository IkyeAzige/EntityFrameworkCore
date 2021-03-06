// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.EntityFrameworkCore.TestUtilities;

namespace Microsoft.EntityFrameworkCore.Query
{
    public class NullKeysOracleTest : NullKeysTestBase<NullKeysOracleTest.NullKeysOracleFixture>
    {
        public NullKeysOracleTest(NullKeysOracleFixture fixture)
            : base(fixture)
        {
        }

        public class NullKeysOracleFixture : NullKeysFixtureBase
        {
            protected override ITestStoreFactory TestStoreFactory => OracleTestStoreFactory.Instance;
        }
    }
}
