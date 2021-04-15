﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeartAttackApp.Model
{
    class Hospital
    {
        public List<Patient> patients{ get; set; }

        public int size;

        public Hospital()
        {
          patients = new List<Patient> ();
          this.size = 0;
        }

        public void add(int idPatient, string age, string genre, string typeDolor, string bloodPressure, string cholesterol, string levelSugar, string angina, string resultElectro, string heartRate, string result)
        {
            Patient patient = null;
            for (int i = 0; i < size; i++) {
                if (patients.ElementAt(i).id ==idPatient )
                {
                    patient =patients.ElementAt(i);
                    break;
                }
            }
            if (patient == null)
            {
               patient = new Patient(idPatient, age, genre, typeDolor, bloodPressure, cholesterol, levelSugar, angina, resultElectro, heartRate);
                patients.Add(patient);
                size++;
            }
        }

        public List<Patient> classify(int id)
        {
            List<Patient> result = new List<Patient>();
            foreach(Patient patient in patients)
            {
                if (patient.id.Equals(id))
                {
                    result.Add(patient); ;
                    break;
                }
            }
            
            return result;
        }

        public List<Patient> classify(string type, int lower,int higger)
        {
            List<Patient> result = new List<Patient>();
            int aux = 0;
            foreach (Patient patient in patients)
            {
                switch (type)
                {
                    case Patient.AGE:
                        aux = int.Parse(patient.age);
                        break;
                    case Patient.BLOOD_PRESSURE:
                        aux = int.Parse(patient.bloodPressure);
                        break;
                    case Patient.CHOLESTEROL:
                       aux = int.Parse(patient.cholesterol);
                        break;
                    case Patient.HEART_RATE:
                        aux = int.Parse(patient.heartRate);
                        break;
                    default:
                        aux = 0;
                        break;
                }
                if (aux >= lower && aux <= higger)
                {
                    result.Add(patient);
                }
            }

            return result;
        }

        public List<Patient> classify(string type, int value)
        {
            List<Patient> result = new List<Patient>();
            int aux = 0;
            foreach (Patient patient in patients)
            {
                switch (type)
                {
                    case Patient.GENRE:
                        aux = int.Parse(patient.genre);
                        break;
                    case Patient.TYPE_PAIN:
                        aux = int.Parse(patient.typePain);
                        break;
                    case Patient.LEVEL_SUGAR:
                        aux = int.Parse(patient.levelSugar);
                        break;
                    case Patient.RESULT_ELECTRO:
                        aux = int.Parse(patient.resultElectro);
                        break;
                    case Patient.ANGINA:
                        aux = int.Parse(patient.angina);
                        break;
                    default:
                        aux = 0;
                        break;
                }
                if (aux == value)
                {
                    result.Add(patient);
                }
            }

            return result;
        }
    }
}
