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
    public class PerIndicator : IEntityTypeConfiguration<Performance>
    {
        public void Configure(EntityTypeBuilder<Performance> builder)
        {
            builder.HasData(
                new Performance
                {
                    Id = 1,
                    ObjectiveID = 1,
                    QET="Quality",
                    Outstanding= "Demonstrated Level 7 in Objective 1 as shown in COT rating sheets/interobserver agreement forms",
                    VerySatisfactory= "Demonstrated Level 6 in Objective 1 as shown in COT rating sheets/interobserver agreement form",
                    Satisfactory= "Demonstrated Level 5 in Objective 1 as shown in COT rating sheets/interobserver agreement forms",
                    Unsatisfactory= "Demonstrated Level 4 in Objective 1 as shown in COT rating sheets/interobserver agreement forms",
                    Poor= "Demonstrated Level 3 in Objective 1 as shown in COT rating sheets/interobserver agreement forms or No acceptable evidence was shown"
                          
                }, new Performance
                {
                    Id = 2,
                    ObjectiveID = 1,
                    QET = "Efficiency",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 3,
                    ObjectiveID = 1,
                    QET = "Timeliness",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 4,
                    ObjectiveID = 2,
                    QET = "Quality",
                    Outstanding = "Ensured that the ICT used redefine and transform learning experiences and are documented properly and consistently using any referencing style as shown in the submitted learning material",
                    VerySatisfactory = "Ensured that the ICT used augment and enrich learning experiences and are documented properly and consistently using any referencing style as shown in the submitted learning material",
                    Satisfactory = "Ensured that the ICT used modify processes and improve learning experiences and are documented properly and consistently using any referencing style as shown in the submitted learning material",
                    Unsatisfactory = "Ensured that ICT are used but do not create a new learning experience and/or are documented but not consistent with one referencing style as shown in the submitted learning material",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 5,
                    ObjectiveID = 2,
                    QET = "Efficiency",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 6,
                    ObjectiveID = 2,
                    QET = "Timeliness",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 7,
                    ObjectiveID = 3,
                    QET = "Quality",
                    Outstanding = "Applied teaching strategies that challenge learners to draw conclusions and justify their thinking or put parts together to promote deeper understanding of ideas learned as shown in the submitted learning material",
                    VerySatisfactory = "Applied teaching strategies that require learners to make connections using ideas learned as shown in the submitted learning material",
                    Satisfactory = "Applied teaching strategies that require learners to describe and explain ideas learned as shown in the submitted learning material",
                    Unsatisfactory = "Applied teaching strategies that lead learners along a single path of inquiry and/or to simple recall and rote memorization of concepts as shown in the submitted learning material",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 8,
                    ObjectiveID = 3,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 9,
                    ObjectiveID = 3,
                    QET = "Timeliness",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 10,
                    ObjectiveID = 4,
                    QET = "Quality",
                    Outstanding = "Utilized effective teaching strategies that are appropriate in responding to learners’ linguistic, cultural, socioeconomic, or religious backgrounds at an individual level* as shown in the submitted learning material",
                    VerySatisfactory = "Utilized effective teaching strategies that are appropriate in responding to learners’ linguistic, cultural, socioeconomic, or religious backgrounds at a group level* as shown in the submitted learning material",
                    Satisfactory = "Utilized an effective teaching strategy that is appropriate in responding to learners’ linguistic, cultural, socioeconomic, or religious backgrounds as shown in the submitted learning material",
                    Unsatisfactory = "Utilized a teaching strategy or strategies that partially respond to learners’ linguistic, cultural, socioeconomic, or religious backgrounds as shown in the submitted learning material",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 11,
                    ObjectiveID = 4,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 12,
                    ObjectiveID = 4,
                    QET = "Timeliness",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 13,
                    ObjectiveID = 5,
                    QET = "Quality",
                    Outstanding = "Demonstrated Level 7 in Objective 5 as shown in COT rating sheets/interobserver agreement forms",
                    VerySatisfactory = "Demonstrated Level 6 in Objective 5 as shown in COT rating sheets/interobserver agreement forms",
                    Satisfactory = "Demonstrated Level 5 in Objective 5 as shown in COT rating sheets/interobserver agreement forms",
                    Unsatisfactory = "Demonstrated Level 4 in Objective 5 as shown in COT rating sheets/interobserver agreement forms",
                    Poor = "Demonstrated Level 3 in Objective 5 as shown in COT rating sheets/interobserver agreement forms or No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 14,
                    ObjectiveID = 5,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 15,
                    ObjectiveID = 5,
                    QET = "Timeliness",
                    Outstanding = " ",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 16,
                    ObjectiveID = 6,
                    QET = "Quality",
                    Outstanding = "Provided learners with accurate, and specific and directed constructive feedback* as shown in the evidence submitted",
                    VerySatisfactory = "Provided learners with accurate, and specific constructive feedback as shown in the evidence submitted",
                    Satisfactory = "Provided learners with accurate, and general constructive feedback as shown in the evidence submitted",
                    Unsatisfactory = "Provided learners with inaccurate and/or destructive feedback as shown in the evidence submitted",
                    Poor = "No evidence was shown"

                }, new Performance
                {
                    Id = 16,
                    ObjectiveID = 6,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 17,
                    ObjectiveID = 6,
                    QET = "Timeliness",
                    Outstanding = "MOV submitted shows feedback given within 5 working days from submission**",
                    VerySatisfactory = "MOV submitted shows feedback given within 6-10 working days from submission**",
                    Satisfactory = "MOV submitted shows feedback given within 11-20 working days from submission**",
                    Unsatisfactory = "MOV submitted shows feedback given beyond 20 working days from submission**",
                    Poor = "No evidence was shown"

                }, new Performance
                {
                    Id = 18,
                    ObjectiveID = 7,
                    QET = "Quality",
                    Outstanding = "Demonstrated Level 7 in Objective 7 as shown in COT rating sheets/interobserver agreement forms",
                    VerySatisfactory = " Demonstrated Level 6 in Objective 7 as shown in COT rating sheets/interobserver agreement forms",
                    Satisfactory = "Demonstrated Level 5 in Objective 7 as shown in COT rating sheets/interobserver agreement forms",
                    Unsatisfactory = "Demonstrated Level 4 in Objective 7 as shown in COT rating sheets/interobserver agreement forms",
                    Poor = "Demonstrated Level 3 in Objective 7 as shown in COT rating sheets/interobserver agreement forms or No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 19,
                    ObjectiveID = 7,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 20,
                    ObjectiveID = 7,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 21,
                    ObjectiveID = 8,
                    QET = "Quality",
                    Outstanding = "All of the learning outcomes set are aligned with the learning competencies as shown in the MOV submitted",
                    VerySatisfactory = "Majority of the learning outcomes set are aligned with the learning competencies as shown in the MOV submitted",
                    Satisfactory = "Half of the learning outcomes set are aligned with the learning competencies as shown in the MOV submitted",
                    Unsatisfactory = "Less than half of the learning outcomes set are aligned with the learning competencies as shown in the MOV submitted",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 22,
                    ObjectiveID = 8,
                    QET = "Efficiency",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 23,
                    ObjectiveID = 8,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 24,
                    ObjectiveID = 9,
                    QET = "Quality",
                    Outstanding = "Sustained engagement with parents/ guardians and/ or wider school community to facilitate involvement in the educative process as evidenced by 2 or more of MOV no. 1 or 2",
                    VerySatisfactory = "Secured collaboration with parents/ guardians and/ or wider school community to facilitate involvement in the educative process as evidenced by one MOV no. 1 or 2",
                    Satisfactory = "Communicated with and obtained response from parents/ guardians and/ or wider school community to facilitate involvement in the educative process as evidenced by MOV No. 3",
                    Unsatisfactory = "Communicated with parents/ guardians and/or wider school community to facilitate involvement in the educative process but received no response/reply as evidenced by MOV No. 3",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 25,
                    ObjectiveID = 9,
                    QET = "Efficiency",
                    Outstanding = "Submitted any 4 of the acceptable MOV*",
                    VerySatisfactory = "Submitted any 3 of the acceptable MOV*",
                    Satisfactory = "Submitted any 2 of the acceptable MOV*",
                    Unsatisfactory = "Submitted any 1 of the acceptable MOV",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 26,
                    ObjectiveID = 9,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 27,
                    ObjectiveID = 10,
                    QET = "Quality",
                    Outstanding = "Participated in any professional network/ activity that requires output* and proof of implementation ** within the school to share knowledge and to enhance practice as evidenced by the submitted MOV",
                    VerySatisfactory = "Participated in any professional network/ activity that requires output* and proof of implementation ** within the department/grade level to share knowledge and to enhance practice as evidenced by the submitted MOV",
                    Satisfactory = "Participated in any professional network/ activity that requires output* to share knowledge and to enhance practice as evidenced by the submitted MOV",
                    Unsatisfactory = "Participated in any professional network/ activity that does not require output to share knowledge and to enhance practice as evidenced by the submitted MOV",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 28,
                    ObjectiveID = 10,
                    QET = "Efficiency",
                    Outstanding = "Submitted 4 different kinds of acceptable MOV***",
                    VerySatisfactory = "Submitted 3 different kinds of acceptable MOV***",
                    Satisfactory = "Submitted 2 different kinds of acceptable MOV***",
                    Unsatisfactory = "Submitted 1 of the acceptable MOV",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 29,
                    ObjectiveID = 10,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 30,
                    ObjectiveID = 11,
                    QET = "Quality",
                    Outstanding = "Updated the Development Plan and approved by the rater during Phase II of the RPMS cycle",
                    VerySatisfactory = "Discussed progress on the Development Plan with the rater to check whether Development Needs were addressed",
                    Satisfactory = "Accomplished the Development Plan from learning objectives up to resources needed to address Development Needs during Phase I of the RPMS cycle",
                    Unsatisfactory = "Accomplished the Strengths and Development Needs portion of the Development Plan after self-assessment at the beginning of the school year",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 31,
                    ObjectiveID = 11,
                    QET = "Efficiency",
                    Outstanding = "Submitted the IPCRF-DP with any 4 of the acceptable Supporting MOV*",
                    VerySatisfactory = "Submitted the IPCRF-DP with any 3 of the acceptable Supporting MOV*",
                    Satisfactory = "Submitted the IPCRF-DP with any 2 of the acceptable Supporting MOV*",
                    Unsatisfactory = "Submitted the IPCRF-DP with any 1 of the acceptable Supporting MOV",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 32,
                    ObjectiveID = 11,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }, new Performance
                {
                    Id = 33,
                    ObjectiveID = 12,
                    QET = "Quality",
                    Outstanding = "Performed at least 1 related work/activity that contributed to the teaching-learning process beyond the school/ Community Learning Center (CLC) as evidenced by submitted MOV",
                    VerySatisfactory = "Performed at least 1 related work/activity that contributed to the teaching-learning process within the school/ Community Learning Center (CLC) as evidenced by submitted MOV",
                    Satisfactory = "Performed at least 1 related work/activity that contributed to the teaching-learning process within the learning area/ department as evidenced by submitted MOV",
                    Unsatisfactory = "Performed at least 1 related work/activity that contributed to the teaching-learning process within the class as evidenced by submitted MOV",
                    Poor = "No acceptable evidence was shown"
                }, new Performance
                {
                    Id = 31,
                    ObjectiveID = 12,
                    QET = "Efficiency",
                    Outstanding = "Submitted any 4 of the acceptable MOV*",
                    VerySatisfactory = "Submitted any 3 of the acceptable MOV*",
                    Satisfactory = "Submitted any 2 of the acceptable MOV*",
                    Unsatisfactory = "Submitted any 1 of the acceptable MOV",
                    Poor = "No acceptable evidence was shown"

                }, new Performance
                {
                    Id = 32,
                    ObjectiveID = 12,
                    QET = "Timeliness",
                    Outstanding = "",
                    VerySatisfactory = "",
                    Satisfactory = "",
                    Unsatisfactory = "",
                    Poor = ""

                }
                );
        }
    }
}
