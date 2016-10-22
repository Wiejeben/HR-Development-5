using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRM
{
    public class Degree : Model<Degree>
    {
        public int Id { get; private set; }
        public int SchoolId { get; set; }
        public int LevelId { get; set; }
        public int CourseId { get; set; }

        private School _school;
        public School School
        {
            get
            {
                if (this._school == null)
                {
                    this._school = new School().Find(this.SchoolId.ToString());
                }

                return this._school;
            }
        }

        private Level _level;
        public Level Level
        {
            get
            {
                if (this._level == null)
                {
                    this._level = new Level().Find(this.LevelId.ToString());
                }

                return this._level;
            }
        }

        private Course _course;
        public Course Course
        {
            get
            {
                if (this._course == null)
                {
                    this._course = new Course().Find(this.CourseId.ToString());
                }

                return this._course;
            }
        }

        public Degree()
        {
            this.AutoIncrementColumn = "id";
            this.PrimaryKey = "id";
        }
    }
}
