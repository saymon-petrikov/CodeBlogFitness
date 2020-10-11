using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeBlogFitness.BL.Model
{
    /// <summary>
    /// User.
    /// </summary>
    public class User
    {
        #region User propertys
        /// <summary>
        /// Name.
        /// </summary>
        public string Name { get; }
    
        /// <summary>
        /// Gender.
        /// </summary>
        public Gender Gender { get; }

        /// <summary>
        /// Birth date.
        /// </summary>
        public DateTime BirthDate { get; }

        /// <summary>
        /// Weight.
        /// </summary>
        public double Weight { get; set; }

        /// <summary>
        /// Heigth.
        /// </summary>
        public double Height { get; set; }
        #endregion

        /// <summary>
        /// Create new User.
        /// </summary>
        /// <param name="name"> Name. </param>
        /// <param name="gender"> Gender. </param>
        /// <param name="birthDate"> Birth date. </param>
        /// <param name="weight"> Weigth. </param>
        /// <param name="height"> Heigth. </param>
        public User(string name, Gender gender, DateTime birthDate, double weight, double height)
        {

            #region Statements cheking
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException("User name cannot be empty!", nameof(name));
            }

            if(gender == null)
            {
                throw new ArgumentNullException("Gender cannot be null.", nameof(gender));
            }

            if((birthDate < DateTime.Parse("01.01.1900")) || (birthDate >= DateTime.Now))
            {
                throw new ArgumentException("Not valide birth date.", nameof(birthDate));
            }

            if(weight <= 0)
            {
                throw new ArgumentException("Weight cannot be 0 or less.", nameof(weight));
            }

            if(height <= 0)
            {
                throw new ArgumentException("Height cannot be les or equal 0.", nameof(height));
            }
            #endregion

            Name = name;
            Gender = gender;
            BirthDate = birthDate;
            Weight = weight;
            Height = height;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
