using System;
namespace PracticeM1_CalculateAverage;

class Program{
	public static void Main(){
		CalculateNumbers numberObj=new CalculateNumbers();

		numberObj.AddNumbers(7);
		numberObj.AddNumbers(9);
		numberObj.AddNumbers(8);
		numberObj.AddNumbers(10);
		numberObj.AddNumbers(7);
		

		numberObj.AddNumbers(10);
		numberObj.GetGPAScore();
		Console.WriteLine("The grade of the student is : {0}",numberObj.GetGradeScore(numberObj.GetGPAScore()));

		}
}
