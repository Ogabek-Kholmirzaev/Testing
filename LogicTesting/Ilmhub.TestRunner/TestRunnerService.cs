using System.Reflection;

namespace Ilmhub.TestRunner;

public static class TestRunnerService
{
    public static void StartTests()
    {
        Console.WriteLine("Test started");

        //type nomida Test qatnashgan classlarni listi
        var testClassTypes = AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(a => a.GetTypes().Where(t => t.IsClass && t.GetCustomAttribute<TestClassAttribute>() != null))
            .ToList();

        foreach (var testClassType in testClassTypes)
        {
            //typedan olingan object
            var testObj = Activator.CreateInstance(testClassType);

            //typeni funksiyalari listi
            var logicServiceTestTestMethods = testClassType.GetMethods();

            //funksiyalarni ishga tushirib beryapdi
            logicServiceTestTestMethods
                .Where(m => m.GetCustomAttribute<TestMethodAttribute>() != null)
                .ToList().ForEach(testMethod => Run(testMethod, testObj));
        }

        void Run(MethodInfo testMethodInfo, object? testObj)
        {
            Console.WriteLine($"{testMethodInfo.ReflectedType?.Name}.{testMethodInfo.Name}");

            //test funksiyani ishga tushirib beryapdi
            var attributes = testMethodInfo.GetCustomAttributes<TestMethodParameters>();
            if (attributes?.Count() > 0)
            {
                int k = 1;
                foreach (var methodData in attributes)
                {
                    Console.Write($"Test{k}: ");
                    k++;
                    testMethodInfo.Invoke(testObj, parameters: methodData?.Parameters);
                }
            }
            else
            {
                Console.Write("Test1: ");

                testMethodInfo.Invoke(testObj, parameters: null);
            }

            Console.WriteLine();
        }

        Console.ReadKey();

    }
}