using System;
using System.Collections.Generic;
using System.Text;

namespace BadSmell
{
    static class LongMethod
    {
        public static void FooBar(string someParameterThatIsAlwaysEmpty)
        {
            var someResturnValueThatWillBeIgnored = LongMethod.ExecuteThisExtremlyLongMethodWithSomeExtremlyComplicatedContentAndSomeRandomParametersAndReturnAStringBecauseAdditionOfAReturnValueMakeyTheCallEvenLonger(someParameterThatIsAlwaysEmpty);

        }

        public static string ExecuteThisExtremlyLongMethodWithSomeExtremlyComplicatedContentAndSomeRandomParametersAndReturnAStringBecauseAdditionOfAReturnValueMakeyTheCallEvenLonger(string param)
        {

            return param;
        }
    }
}
