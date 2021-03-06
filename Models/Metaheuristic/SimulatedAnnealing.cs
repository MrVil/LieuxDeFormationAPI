﻿using System;
using LieuxDeFormationAPI.Models.TrainingProblem;
using System.Collections.Generic;

namespace LieuxDeFormationAPI.Models.Metaheuristic
{
    public class SimulatedAnnealing
    {
        double t = 0.0;
        private Random rand = new Random();//LieuxDeFormation.MainClass.rand;

        public SimulatedAnnealing(List<Agency> agencies, List<City> cities)
        {
            
        }

        public Solution run(int iteration, int populationSize, double initialTemperature){

            List<Solution> population = new List<Solution>();

            for (int i = 0; i < populationSize; i++)
                population.Add(new Solution());

            t = initialTemperature;
            double µ = 0.5;
            int param = 10;
            Solution xmin, xn, xnn, x0 = new Solution();
            xmin = x0;
            xn = x0;
            double fmin = xmin.Cost;

            for (int i = 0; i < iteration; i++)
            {
                Console.WriteLine("ITER: " + i + " --> " + "actuel: " + xn.Cost + " min: " + xmin.Cost);
                Solution y = new Solution();//xn.Neighbors2[rand.Next(xn.Neighbors2.Count)];
                //Console.WriteLine("--> voisin: " + y.Cost);
                double Δf = (y.Cost/1) - (xn.Cost/1);
                if (Δf <= 0)
                {
                    xnn = y;
                    if ((xnn.Cost / 1) < (xmin.Cost / 1))
                        xmin = xnn;
                }
                else {
                    if (rand.NextDouble() <= Math.Exp(-Δf / t))
                        xnn = y;
                    else
                        xnn = xn;
                }
                xn = xnn;
                /*if (i % param == 0)
                    t = µ * t;*/
            }
            return xmin;
        }
    }
}

