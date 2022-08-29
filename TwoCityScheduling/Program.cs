/// Touch one for sure!!!!
int[][] costs = new int[][] { new int[] {515,563 }, new int[] { 451,713}, new int[] { 537,709},
                new int[]{ 343, 819 },  new int[]{ 855,779 },  new int[]{ 457,60 },
                new int[] {650, 359 },new int[] { 631, 42 } }; // 3086

// [[10,20],[30,200],[400,50],[30,20]]
//= [[515,563],[451,713],[537,709],[343,819],[855,779],[457,60],[650,359],[631,42]]

int minCost = 0;
int[][] diff = new int[costs.Length][];


for (int i = 0; i < costs.Length; i++)
{
    var valueToAppend = new int[] { costs[i][1] - costs[i][0], costs[i][0], costs[i][1] };

    diff[i] = valueToAppend;
}

Array.Sort(diff, (a, b) => { return a[0] - b[0]; });

for (int i = 0; i < costs.Length / 2; i++)
{
    minCost += diff[i][2] + diff[costs.Length - 1 - i][1];
}

Console.Write(minCost);

Console.Read();

// Finally I can sleep!!! 1:35 AM
