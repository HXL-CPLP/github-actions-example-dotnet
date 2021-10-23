// SPDX-License-Identifier: Unlicense
// _[por-Latn]
// Este arquivo não está, de fato, testando o programa principal.
//
// @see https://xunit.net/docs/getting-started/netcore/cmdline
// @see https://docs.microsoft.com/pt-br/dotnet/core/testing/unit-testing-best-practices
// [por-Latn]

using Xunit;

namespace ProgramTests
{
    public class UnitTest1
    {
        [Fact]
        public void PassingTest()
        {
            Assert.Equal(4, Add(2, 2));
        }

        // [Fact]
        // public void FailingTest()
        // {
        //     Assert.Equal(5, Add(2, 2));
        // }

        int Add(int x, int y)
        {
            return x + y;
        }
    }
}