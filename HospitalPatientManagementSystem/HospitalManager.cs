using System;

namespace HospitalPatientManagementSystem;

public class HospitalManager
{
    private Dictionary<int, Patient> _patients = new Dictionary<int, Patient>();
    private Queue<Patient> _appointmentQueue = new Queue<Patient>();

    Patient patientObj = new Patient();
    
    // Add a new patient to the system
    public void RegisterPatient(int id, string name, int age, string condition)
    {
        // TODO: Create patient and add to dictionary
        if(!_patients.ContainsKey(id))
        {
        patientObj.ID = id;
        patientObj.Name = name;
        patientObj.Age = age;
        patientObj.Condition = condition;

        _patients.Add(id,patientObj);
        }
        else
        {
            Console.WriteLine("Patient id already exists");
        }

    }
    
    // Add patient to appointment queue
    public void ScheduleAppointment(int patientId)
    {
        // TODO: Find patient and add to queue
        if (_patients.ContainsKey(patientId))
        {
            _appointmentQueue.Enqueue(_patients[patientId]);
        }
        else
        {
            Console.WriteLine("Patient id is not found");
        }
    }
    
    // Process next appointment (remove from queue)
    public Patient ProcessNextAppointment()
    {
        // TODO: Return and remove next patient from queue
        Patient nextPatient = _appointmentQueue.Dequeue();

        return nextPatient;

    }
    
    // Find patients with specific condition using LINQ
    public List<Patient> FindPatientsByCondition(string condition)
    {
        
    //     List<Patient> patientConditions = new List<Patient>();

    //     foreach(var item in _patients.Values)
    //     {
    //         if(item.Condition == condition)
    //         {
    //             patientConditions.Add(item);
    //         }
    //     }
    //  return patientConditions;   

     // TODO: Use LINQ to filter patients
     return _patients.Values.Where(p=>p.Condition ==condition).ToList();


    }
}
