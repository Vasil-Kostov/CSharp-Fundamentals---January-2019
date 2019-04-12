namespace _04.WorkForce
{
    using System.Collections.Generic;

    class JobRepository : List<Job>
    {
        public void AddJob(Job job)
        {
            this.Add(job);
            job.JobFinished += this.RemoveJobWhenIsFinished;
        }

        public void RemoveJobWhenIsFinished(Job job)
        {
            this.Remove(job);
        }
    }
}
