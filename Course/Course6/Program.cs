using System;
using Course6.Entities;
using Course6.Entities.Enums;
using Course6.WorkerEntities;
using Course6.WorkerEntities.Enums;
using Course6.PostEntities;
using Course6.OSEntities;
using Course6.OSEntities.Enums;

namespace Course6
{
    class Program
    {
        static void Main(string[] args)
        {
            //ServiceOrder serviceOrder = new();
            //serviceOrder.Order();

            //WorkerCall workerCall = new WorkerCall();
            //workerCall.Call();

            //PostCall postCall = new();
            //postCall.Call();

            ExerciceServiceOrderCall exerciceServiceOrderCall = new();
            exerciceServiceOrderCall.Call();

        }
    }
}