using Strategy_Design_Pattern.Models;

Context context = new Context(new AscendingSortingStrategy());
int[] arr = new int[5] { 1, 5, 3, 5, 2 };

context.Sort(arr);

context.SetStrategy(new DescendingSortingStrategy());

context.Sort(arr);