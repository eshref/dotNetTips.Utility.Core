﻿// ***********************************************************************
// Assembly         : dotNetTips.Utility.Standard.Tester
// Author           : David McCarter
// Created          : 07-17-2019
//
// Last Modified By : David McCarter
// Last Modified On : 05-27-2020
// ***********************************************************************
// <copyright file="PersonProper.cs" company="dotNetTips.com - David McCarter">
//     McCarter Consulting (David McCarter)
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Runtime.Serialization;
using System.Xml.Serialization;
using dotNetTips.Utility.Standard.Extensions;
using dotNetTips.Utility.Standard.OOP;
using dotNetTips.Utility.Standard.Tester.Properties;

namespace dotNetTips.Utility.Standard.Tester.Models
{
    /// <summary>
    /// Person class that implements interfaces and validates data.
    /// Implements the <see cref="dotNetTips.Utility.Standard.Tester.Models.IPerson" />
    /// Implements the <see cref="System.IComparable" />
    /// </summary>
    /// <seealso cref="dotNetTips.Utility.Standard.Tester.Models.IPerson" />
    /// <seealso cref="System.IComparable" />
    [DebuggerDisplay("{Email}")]
    [Serializable]
    [XmlRoot(ElementName = "PersonProper", Namespace = "http://dotNetTips.Utility.Standard.Tester.Models")]
    [DataContract(Name = "personProper", Namespace = "http://dotNetTips.Utility.Standard.Tester.Models")]
    public sealed class PersonProper : IPerson, IDataModel<PersonProper, string>
    {

        /// <summary>
        /// Address 1.
        /// </summary>
        [NonSerialized]
        private string _address1;

        /// <summary>
        /// Address 2.
        /// </summary>
        [NonSerialized]
        private string _address2;

        /// <summary>
        /// The born on date and time.
        /// </summary>
        [NonSerialized]
        private DateTimeOffset _bornOn;

        /// <summary>
        /// The cell phone number.
        /// </summary>
        [NonSerialized]
        private string _cellPhone;

        /// <summary>
        /// The city name.
        /// </summary>
        [NonSerialized]
        private string _city;

        /// <summary>
        /// The country name.
        /// </summary>
        [NonSerialized]
        private string _country = "USA";

        /// <summary>
        /// The email address.
        /// </summary>
        [NonSerialized]
        private string _email;

        /// <summary>
        /// The first name.
        /// </summary>
        [NonSerialized]
        private string _firstName;

        /// <summary>
        /// The home phone number.
        /// </summary>
        [NonSerialized]
        private string _homePhone;

        /// <summary>
        /// The unique identifier.
        /// </summary>
        [NonSerialized]
        private string _id;

        /// <summary>
        /// The last name.
        /// </summary>
        [NonSerialized]
        private string _lastName;

        /// <summary>
        /// The postal code.
        /// </summary>
        [NonSerialized]
        private string _postalCode;

        /// <summary>
        /// Initializes a new instance of <see cref="PersonFixed" />.
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Never)]
        public PersonProper()
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="PersonFixed" />.
        /// </summary>
        /// <param name="id">The unique identifier.</param>
        /// <param name="email">The email address.</param>
        public PersonProper(string id, string email)
        {
            this.Id = id;
            this.Email = email;
        }

        /// <summary>
        /// Gets or sets first address.
        /// </summary>
        /// <value>The address1.</value>
        /// <exception cref="ArgumentOutOfRangeException">Address1 - Address length is limited to 100 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Address1 - Address length is limited to 100 characters.</exception>
        [DataMember(Name = "address1")]
        [XmlElement]
        public string Address1
        {
            get
            {
                return this._address1;
            }

            set
            {
                if (this._address1 == value)
                {
                    return;
                }

                this._address1 = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.Address1), Resources.AddressLengthIsLimitedTo100Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets second address.
        /// </summary>
        /// <value>The address2.</value>
        /// <exception cref="ArgumentOutOfRangeException">Address2 - Address length is limited to 100 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Address2 - Address length is limited to 100 characters.</exception>
        [DataMember(Name = "address2")]
        [XmlElement]
        public string Address2
        {
            get
            {
                return this._address2;
            }

            set
            {
                if (this._address2 == value)
                {
                    return;
                }

                this._address2 = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.Address2), Resources.AddressLengthIsLimitedTo100Characters) : value;
            }
        }

        /// <summary>
        /// Gets the person's current age.
        /// </summary>
        /// <value>The age.</value>
        [IgnoreDataMember]
        public TimeSpan Age => this.CalculateAge();

        /// <summary>
        /// Gets or sets the born on date and time.
        /// </summary>
        /// <value>The born on.</value>
        /// <exception cref="ArgumentOutOfRangeException">BornOn - Person BornOn cannot be in the future.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">BornOn - Person BornOn cannot be in the future.</exception>
        [DataMember(Name = "bornOn")]
        [XmlElement]
        public DateTimeOffset BornOn
        {
            get
            {
                return this._bornOn;
            }

            set
            {
                if (this._bornOn == value)
                {
                    return;
                }

                this._bornOn = value.ToUniversalTime() > DateTimeOffset.UtcNow ? throw new ArgumentOutOfRangeException(nameof(this.BornOn), Resources.PersonBornOnCannotBeInTheFuture) : value;
            }
        }

        /// <summary>
        /// Gets or sets the cell phone number.
        /// </summary>
        /// <value>The cell phone.</value>
        /// <exception cref="ArgumentOutOfRangeException">CellPhone - Address length is limited to 50 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">CellPhone - Address length is limited to 50 characters.</exception>
        [DataMember(Name = "cellPhone")]
        [XmlElement]
        public string CellPhone
        {
            get
            {
                return this._cellPhone;
            }

            set
            {
                if (this._cellPhone == value)
                {
                    return;
                }

                this._cellPhone = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.CellPhone), Resources.PhoneNumberIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the city name.
        /// </summary>
        /// <value>The city.</value>
        /// <exception cref="ArgumentOutOfRangeException">City - City length is limited to 100 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">City - City length is limited to 100 characters.</exception>
        [DataMember(Name = "city")]
        [XmlElement]
        public string City
        {
            get
            {
                return this._city;
            }

            set
            {
                if (this._city == value)
                {
                    return;
                }

                this._city = value.HasValue(0, 100) == false ? throw new ArgumentOutOfRangeException(nameof(this.City), Resources.CityLengthIsLimitedTo100Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the country.
        /// </summary>
        /// <value>The country.</value>
        /// <exception cref="ArgumentOutOfRangeException">Country - Country length is limited to 50 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Country - Country length is limited to 50 characters.</exception>
        [DataMember(Name = "country")]
        [XmlElement]
        public string Country
        {
            get
            {
                return this._country;
            }

            set
            {
                if (this._country == value)
                {
                    return;
                }

                this._country = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.Country), Resources.CountryLengthIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets the email.
        /// </summary>
        /// <value>The email.</value>
        /// <exception cref="ArgumentOutOfRangeException">Email - Email length is limited to 75 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Email - Email length is limited to 75 characters.</exception>
        [DataMember(Name = "email", IsRequired = true)]
        [XmlElement(IsNullable = false)]
        public string Email
        {
            get
            {
                return this._email;
            }

            set
            {
                if (this._email == value)
                {
                    return;
                }

                this._email = value.HasValue(0, 75) == false ? throw new ArgumentOutOfRangeException(nameof(this.Email), Resources.EmailLengthIsLimitedTo75Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        /// <value>The first name.</value>
        /// <exception cref="ArgumentOutOfRangeException">Email - First name length is limited to 50 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Email - First name length is limited to 50 characters.</exception>
        [DataMember(Name = "firstName")]
        [XmlElement]
        public string FirstName
        {
            get
            {
                return this._firstName;
            }
            set
            {
                if (this._firstName == value)
                {
                    return;
                }

                this._firstName = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.FirstName), Resources.FirstNameLengthIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the home phone.
        /// </summary>
        /// <value>The home phone.</value>
        /// <exception cref="ArgumentOutOfRangeException">HomePhone - Home phone length is limited to 50 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">HomePhone - Home phone length is limited to 50 characters.</exception>
        [DataMember(Name = "homePhone")]
        [XmlElement]
        public string HomePhone
        {
            get
            {
                return this._homePhone;
            }
            set
            {
                if (this._homePhone == value)
                {
                    return;
                }

                this._homePhone = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.HomePhone), Resources.PhoneNumberIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets the identifier.
        /// </summary>
        /// <value>The identifier.</value>
        /// <exception cref="ArgumentOutOfRangeException">Id - Id length is limited to 256 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">Id - Id length is limited to 256 characters.</exception>
        [DataMember(Name = "id", IsRequired = true)]
        [XmlElement(IsNullable = false)]
        public string Id
        {
            get
            {
                return this._id;
            }
            set
            {
                if (this._id == value)
                {
                    return;
                }

                this._id = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.Id), Resources.IdLengthIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>The last name.</value>
        /// <exception cref="ArgumentOutOfRangeException">LastName - Last name length is limited to 50 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">LastName - Last name length is limited to 50 characters.</exception>
        [DataMember(Name = "lastName")]
        [XmlElement]
        public string LastName
        {
            get
            {
                return this._lastName;
            }
            set
            {
                if (this._lastName == value)
                {
                    return;
                }

                this._lastName = value.HasValue(0, 50) == false ? throw new ArgumentOutOfRangeException(nameof(this.LastName), Resources.LastNameLengthIsLimitedTo50Characters) : value;
            }
        }

        /// <summary>
        /// Gets or sets the postal code.
        /// </summary>
        /// <value>The postal code.</value>
        /// <exception cref="ArgumentOutOfRangeException">PostalCode - Postal code length is limited to 20 characters.</exception>
        /// <exception cref="System.ArgumentOutOfRangeException">PostalCode - Postal code length is limited to 20 characters.</exception>
        [DataMember(Name = "postalCode")]
        [XmlElement]
        public string PostalCode
        {
            get
            {
                return this._postalCode;
            }
            set
            {
                if (this._postalCode == value)
                {
                    return;
                }

                this._postalCode = value.HasValue(0, 15) == false ? throw new ArgumentOutOfRangeException(nameof(this.PostalCode), Resources.PostalCodeLengthIsLimitedTo15Characters) : value;
            }
        }

        /// <summary>
        /// Implements the &gt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >=(PersonProper left, PersonProper right) => left is null ? right is null : left.CompareTo(right) >= 0;

        /// <summary>
        /// Implements the &gt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator >(PersonProper left, PersonProper right) => left is object && left.CompareTo(right) > 0;

        /// <summary>
        /// Implements the == operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator ==(PersonProper left, PersonProper right)
        {
            if (left is null)
            {
                return right is null;
            }

            return left.Equals(right);
        }

        /// <summary>
        /// Implements the &lt;= operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <=(PersonProper left, PersonProper right) => left is null || left.CompareTo(right) <= 0;

        /// <summary>
        /// Implements the &lt; operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator <(PersonProper left, PersonProper right) => left is null ? right is object : left.CompareTo(right) < 0;

        /// <summary>
        /// Implements the != operator.
        /// </summary>
        /// <param name="left">The left.</param>
        /// <param name="right">The right.</param>
        /// <returns>The result of the operator.</returns>
        public static bool operator !=(PersonProper left, PersonProper right) => !(left == right);

        /// <summary>
        /// Compares to.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns>System.Int32.</returns>
        public int CompareTo(PersonProper other)
        {
            if (other == null)
            {
                return 1;
            }

            var result = string.Compare(_address1, other._address1, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_address2, other._address2, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = _bornOn.CompareTo(other._bornOn);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_cellPhone, other._cellPhone, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_city, other._city, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_country, other._country, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_email, other._email, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_firstName, other._firstName, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_homePhone, other._homePhone, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_id, other._id, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_lastName, other._lastName, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            result = string.Compare(_postalCode, other._postalCode, StringComparison.CurrentCultureIgnoreCase);
            if (result != 0)
            {
                return result;
            }

            return result;
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object" /> is equal to this instance.
        /// </summary>
        /// <param name="obj">The object to compare with the current object.</param>
        /// <returns><c>true</c> if the specified <see cref="System.Object" /> is equal to this instance; otherwise, <c>false</c>.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            return false;
        }

        /// <summary>
        /// Equals the specified other.
        /// </summary>
        /// <param name="other">The other.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        /// <exception cref="NotImplementedException"></exception>
        public bool Equals(PersonProper other)
        {
            if (other == null)
            {
                return false;
            }

            return ReferenceEquals(this, other);
        }


        /// <summary>
        /// Returns the hash code for this instance based on id.
        /// </summary>
        /// <returns>A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.</returns>
        public override int GetHashCode()
        {
            //TODO: CHANGE TO HashCode.Combine(Email, Id)
            var hashCode = -1058553241;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(this.Id);
            return hashCode;
        }

        /// <summary>
        /// Returns a <see cref="System.String" /> of the users id.
        /// </summary>
        /// <returns>A <see cref="System.String" /> of the users id.</returns>
        public override string ToString() => this.Id.ToString(CultureInfo.CurrentCulture);

        /// <summary>
        /// Calculates the person's current age.
        /// </summary>
        /// <returns>TimeSpan.</returns>
        private TimeSpan CalculateAge() => DateTimeOffset.UtcNow.Subtract(this.BornOn);

    }
}
