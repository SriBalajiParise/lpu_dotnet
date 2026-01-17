using System;
namespace PracticeM1_CalculateAverage;

class CalculateNumbers{
    List<int> NumberList=new List<int>();
	public void AddNumbers(int numbers){
		
        NumberList.Add(numbers);

    }

	public double GetGPAScore(){
		double gpa=0;
		foreach(var item in NumberList){
			gpa+=item * 3;
						
			}
		return gpa/NumberList.Count;	
		}

	public char GetGradeScore(double gpa){
		char grade='F';
		
		if(gpa == 10){
			grade='S';	
		}		
		else if(gpa>= 9 && gpa<10){
			grade='A';	
		}

		else if(gpa>=8 && gpa<9){
			grade='B';	
		}

		else if(gpa>=7 && gpa<8){
			grade='C';	
		}

		else if(gpa>=6 && gpa<7){
			grade='D';	
		}

		else if(gpa>=5 && gpa<6){
			grade='E';	
		}
        
		return grade;
    }


}
