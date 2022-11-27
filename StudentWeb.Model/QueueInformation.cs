using System;
using StudentWeb.Common;

namespace StudentWeb.Model
{
	/// <summary>
	/// QueueInformation
	/// </summary>
    [Serializable]
	public class QueueInformation
	{
		/// <summary>
		/// UserName
        /// </summary>
        [FieldName("UserName")]		
		public string UserName
		{
			get;
			set;
		}
        
		/// <summary>
		/// UserNumber
        /// </summary>
        [FieldName("UserNumber")]		
		public string UserNumber
		{
			get;
			set;
		}
        
		/// <summary>
		/// UserID
        /// </summary>
        [FieldName("UserID")]		
		public string UserID
		{
			get;
			set;
		}
        
        public QueueInformation Clone()
        {
            return (QueueInformation)this.MemberwiseClone();
        }
        
        public QueueInformation()
        {
            UserName = string.Empty;
            UserNumber = string.Empty;
            UserID = string.Empty;
        }
	}
}
