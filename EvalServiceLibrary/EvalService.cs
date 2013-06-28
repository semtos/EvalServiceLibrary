﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace EvalServiceLibrary
{
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class EvalService : IEvalService
    {
        List<Eval> evals = new List<Eval>();

        public void SubmitEval(Eval eval)
        {
            eval.Id = Guid.NewGuid().ToString();
            evals.Add(eval);
        }

        public List<Eval> GetEvals()
        {
            return evals;
        }

        public void RemoveEval(string id)
        {
            evals.Remove(evals.Find(e => e.Id.Equals(id)));
        }
    }
}
