using System.Diagnostics;
using Pr_Pr_2;

var test = new TestClass();
test[10] = 555;
test[3] = 333;
test.AddElem(10);
test.AddElems(10, 12, 23);
test.AddElems(new List<int>{10, 25, 78});

// var watch = new Stopwatch();
// watch.Start();
// test[40000000] = 999;
// watch.Stop();
// Console.WriteLine((double) watch.ElapsedMilliseconds/1000);

Console.WriteLine(test);
