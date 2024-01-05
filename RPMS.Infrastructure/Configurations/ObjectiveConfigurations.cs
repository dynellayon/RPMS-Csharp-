using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RPMS.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPMS.Infrastructure.Configurations
{
    public class ObjectiveConfigurations : IEntityTypeConfiguration<Objectives>
    {
        public void Configure(EntityTypeBuilder<Objectives> builder)
        {
            builder.HasData(
                new Objectives
                {
                    Id = 1,
                    Kra = 1,
                    Objectivename = "Applied knowledge of content within and across curriculum teaching areas."
                }, new Objectives
                {
                    Id = 2,
                    Kra = 1,
                    Objectivename = "Ensured the positive use of ICT to facilitate the teaching and learning process"
                }, new Objectives
                {
                    Id = 3,
                    Kra = 1,
                    Objectivename = "Applied a range of teaching strategies to develop critical and creative thinking, as well as other higher-order thinking skills"
                }, new Objectives
                {
                    Id = 4,
                    Kra = 2,
                    Objectivename = "Established a learnercentered culture by using teaching strategies that respond to their linguistic, cultural, socioeconomic and religious backgrounds"
                }, new Objectives
                {
                    Id = 5,
                    Kra = 2,
                    Objectivename = "Planned and delivered teaching strategies that are responsive to the special educational needs of learners in difficult circumstances*, including: geographic isolation; chronic illness; displacement due to armed conflict, urban resettlement or disasters; child abuse and child labor practices"
                }, new Objectives
                {
                    Id = 6,
                    Kra = 2,
                    Objectivename = "Used strategies for providing timely, accurate and constructive feedback to improve learner performance"
                }, new Objectives
                {
                    Id = 7,
                    Kra = 3,
                    Objectivename = "Selected, developed, organized and used appropriate teaching and learning resources, including ICT, to address learning goals"
                }, new Objectives
                {
                    Id = 8,
                    Kra = 3,
                    Objectivename = "Set achievable and appropriate learning outcomes that are aligned with learning competencies"
                }, new Objectives
                {
                    Id = 9,
                    Kra = 4,
                    Objectivename = "Built relationships with parents/ guardians and the wider school community to facilitate involvement in the educative process"
                }, new Objectives
                {
                    Id = 10,
                    Kra = 4,
                    Objectivename = " Participated in professional networks to share knowledge and to enhance practice"
                }, new Objectives
                {
                    Id = 11,
                    Kra = 4,
                    Objectivename = " Developed a personal improvement plan based on reflection of one’s practice and ongoing professional learning"
                }, new Objectives
                {
                    Id = 12,
                    Kra = 5,
                    Objectivename = "Performed various related works/ activities that contribute to the teaching-learning process"
                }
                );
        }
    }
}
