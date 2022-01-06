using CarDealership.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CarDealership.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        List<Cars> Lot = new List<Cars>()
        { new Cars(1,"Ford","F150",2017,"Red"),
          new Cars(2,"Chevy","F250",2016,"Blue"),
          new Cars(3,"GMC","F350",2019,"Green"),
          new Cars(4,"Nissan","F450",2018,"Black")
        };
        

        // GET: api/<CarsController>
        [HttpGet]
        public List<Cars> Get()
        {
            return Lot;
        }

        // GET api/<CarsController>/5
        [HttpGet("id/{index}")]
        public List<Cars> Getid(int index)
        {

           return Lot.GetRange(index,1);

        }

        [HttpGet("{make}%{model}")]
        public List<Cars> GetSearch(string make, string model)
        {
            List<Cars> results = new List<Cars> ();

            foreach (var item in Lot)
            {
                if(item.Make == make||item.Model ==  model)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        // POST api/<CarsController>
        [HttpPost]
        public List<Cars> Post([FromBody] Cars value)
        {
            Lot.Add(value);
            return Lot;
        }

        // PUT api/<CarsController>/5
        [HttpPut("{id}")]
        public List<Cars> Put(int id, [FromBody] Cars value)
        {
            Cars update = Lot.Find(f => f.ID == id);
            int index = Lot.IndexOf(update);

            Lot[index].Make = value.Make;
            Lot[index].Model = value.Model;
            Lot[index].Year = value.Year;
            Lot[index].Color = value.Color;

            return Lot;
        }

        // DELETE api/<CarsController>/5
        [HttpDelete("{id}")]
        public List<Cars> Delete(int id)
        {

            Cars delete = Lot.Find(f => f.ID == id);
            Lot.Remove(delete);
            return Lot;

        }
    }
}
