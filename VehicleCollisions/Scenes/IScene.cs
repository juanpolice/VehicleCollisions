﻿using System.Threading.Tasks;
using CitizenFX.Core;
using VehicleCollisions.Entities;

namespace VehicleCollisions.Scenes
{
    public interface IScene
    {
        string Title { get; }
        string Description { get; }
        int ResponseCode { get; }
        float StartDistance { get; }
        Vector3 Coordinates { get; }
        ObjectModel[] ObjectModels { get; }
        PoliceCar[] PoliceCars { get; }
        PolicePed[] PolicePeds { get; }
        CivilianPed[] CivilianPeds { get; }
        CrashedVehicle[] CrashedCars { get; }


        string[] Notifications();

        void Accept();
        void Finish();
        void Start(Ped[] civilianPeds, Vehicle[] crashedCars);
        Task RunAdditionalTasks();
    }
}