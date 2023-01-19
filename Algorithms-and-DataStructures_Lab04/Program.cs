//1.

List<int> aryList1 = new List<int>();
aryList1.AddRange(new int[] { 1, 5, 3 });

List<int> aryList2 = new List<int>();
aryList2.AddRange(new int[] { 9, 7, 3, -2 });

List<int> aryList3 = new List<int>();
aryList3.AddRange(new int[] { 2, 1, 2 });

List<List<int>> aryList4 = new List<List<int>>();
aryList4.Add(aryList1);
aryList4.Add(aryList2);
aryList4.Add(aryList3);
List<int> maxNumbersInLists(List<List<int>> p1)
{
    List<int> result = new List<int>();

    for (int i = 0; i < p1.Count; i++)
    {
        int max;
        List<int> temp = p1[i];
        for (int j = 1; j < temp.Count; j++)
        {
            if (temp[0] < temp[j])
            {

                max = temp[j];
                temp[j] = temp[0];
                temp[0] = max;

            }
        }
        result.Add(temp[0]);
    }

    return result;


}


for (int i = 0; i < maxNumbersInLists(aryList4).Count; i++)
{
    Console.WriteLine($"List {i + 1} has a maximum of {maxNumbersInLists(aryList4)[i]}.");
}


//2.

//List<int> aryList1 = new List<int>();
//aryList1.AddRange(new int[] { 85, 92, 67, 94, 94 });

//List<int> aryList2 = new List<int>();
//aryList2.AddRange(new int[] { 50, 60, 57, 95 });

//List<int> aryList3 = new List<int>();
//aryList3.AddRange(new int[] {95});

//List<List<int>> classGrade = new List<List<int>>();
//classGrade.Add(aryList1);
//classGrade.Add(aryList2);
//classGrade.Add(aryList3);

//List<int> highestGrade(List<List<int>> p2)
//{
//    List<int> result = new List<int>();

//    for (int i = 0; i < p2.Count; i++)
//    {
//        int max;
//        List<int> temp = p2[i];
//        for (int j = 1; j < temp.Count; j++)
//        {
//            if (temp[0] < temp[j])
//            {

//                max = temp[j];
//                temp[j] = temp[0];
//                temp[0] = max;

//            }
//        }
//        result.Add(temp[0]);
//    }

//    return result;

//};

//Console.WriteLine($"The highest grade is {highestGrade(classGrade).Max()}");


//3.

//List<int> orderByLooping = new List<int>();
//orderByLooping.AddRange(new int[] { 6, -2, 5, 3 });

//List<int> orderByLooping(List<List<int>> p3)
//{
//    List<int> result = new List<int>();

//    for(int i = 0; i < p3.Count; i++)
//    {
//        for (int j = i + 1; j < p3.Count; j++)
//        {
//            if (p3[i] > p3[j])
//            {

//            }
//        }
//    }
//}


//for (int i = 0; i < orderByLooping.Count; i++)
//{
//    for (int j = i + 1; j < orderByLooping.Count; j++)
//    {
//        if (orderByLooping[i] > orderByLooping[j])
//        {
//            int temp = orderByLooping[i];
//            orderByLooping[i] = orderByLooping[j];
//            orderByLooping[j] = temp;
//        }
//    }
//}

//Console.WriteLine(string.Join(",", orderByLooping));

