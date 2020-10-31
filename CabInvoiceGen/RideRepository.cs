using CabInvoiceGenerator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading;

namespace CabInvoiceGen
{
    public class RideRepository
    {
        public Dictionary<string, List<Ride>> userRides = new Dictionary<string, List<Ride>>();

        /// <summary>
        /// Adding rides in the dictionary as per userId
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rides"></param>
        public void AddRides(string userId, List<Ride> rides)
        {
            if (userRides.ContainsKey(userId))
            {
                List<Ride> existingRides = userRides[userId];
                existingRides.AddRange(rides);
                userRides[userId] = existingRides;
            }
            else
                userRides.Add(userId, rides);
        }
        /// <summary>
        /// Searching all the rides of a particular user
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<Ride> SearchUserRide(string userId)
        {
            
            List<Ride> ridesOfUser = new List<Ride>();
            foreach(var user in userRides)
            {
                if (user.Key == userId)
                {
                    foreach (Ride ride in user.Value)
                        ridesOfUser.Add(ride);
                }
            }
            return ridesOfUser;
        }

    }
}
