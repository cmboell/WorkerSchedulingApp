using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace WorkerSchedulingApp.Models
{
    //position configuration model
    internal class PositionConfig : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> entity)
        {
            entity.HasOne(p => p.Worker)
                .WithMany(w => w.Positions)
                .OnDelete(DeleteBehavior.Restrict);

            entity.HasData(
                new Position { PositionId = 1, PositionName = "Brewer", HoursPerShift = 10, WorkerId = 1, DayId = 1, MilitaryTime = "0900" },
               new Position { PositionId = 2, PositionName = "Brewer", HoursPerShift = 12, WorkerId = 1, DayId = 2, MilitaryTime = "0900" },
               new Position { PositionId = 3, PositionName = "Brewer", HoursPerShift = 10, WorkerId = 1, DayId = 3, MilitaryTime = "0800" },
               new Position { PositionId = 4, PositionName = "Brewer", HoursPerShift = 8, WorkerId = 1, DayId = 6, MilitaryTime = "0900" },
               new Position { PositionId = 5, PositionName = "Salesman", HoursPerShift = 10, WorkerId = 2, DayId = 1, MilitaryTime = "1200" },
               new Position { PositionId = 6, PositionName = "Salesman", HoursPerShift = 10, WorkerId = 2, DayId = 3, MilitaryTime = "1000" },
               new Position { PositionId = 7, PositionName = "Salesman", HoursPerShift = 10, WorkerId = 2, DayId = 6, MilitaryTime = "1100" },
               new Position { PositionId = 8, PositionName = "Salesman", HoursPerShift = 6, WorkerId = 2, DayId = 7, MilitaryTime = "0900" },
               new Position { PositionId = 9, PositionName = "Bartender", HoursPerShift = 6, WorkerId = 3, DayId = 2, MilitaryTime = "1600" },
                new Position { PositionId = 10, PositionName = "Bartender", HoursPerShift = 6, WorkerId = 3, DayId = 3, MilitaryTime = "1600" },
                 new Position { PositionId = 11, PositionName = "Bartender", HoursPerShift = 6, WorkerId = 3, DayId = 4, MilitaryTime = "1600" },
                 new Position { PositionId = 12, PositionName = "Bartender", HoursPerShift = 6, WorkerId = 3, DayId = 5, MilitaryTime = "1200" },
                  new Position { PositionId = 13, PositionName = "Bartender", HoursPerShift = 6, WorkerId = 3, DayId = 6, MilitaryTime = "1200" },
                   new Position { PositionId = 14, PositionName = "Janitor", HoursPerShift = 6, WorkerId = 4, DayId = 2, MilitaryTime = "0800" },
                    new Position { PositionId = 15, PositionName = "Janitor", HoursPerShift = 8, WorkerId = 4, DayId = 4, MilitaryTime = "1300" },
                 new Position { PositionId = 16, PositionName = "Janitor", HoursPerShift = 8, WorkerId = 4, DayId = 7, MilitaryTime = "1000" }
            );
        }
    }

}
