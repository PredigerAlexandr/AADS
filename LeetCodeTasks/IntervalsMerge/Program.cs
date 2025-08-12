//57. Insert Interval - суть задачи - есть отсортированный список  непересекающихся интервалов. На вход подаётся новый
//интервал и его нужно вставить в этот массив, чтобы он не перескался с другими, если он будет пересекаться, то объединить его с пересекающимся интервалами 

using IntervalsMerge;

var intervals = new[] { new[] { 1, 3 }, new[]{ 6, 9 } };
var newInterval = new[] {2, 5};
var result1 = IntervalMergeImplementation.Execute(intervals, newInterval);
Console.ReadKey();