using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediateka.Files
{
    public class MediatekaObject : ICollection<ImediaObject>
    {

        private  ICollection<ImediaObject> mediaObjects = new List<ImediaObject> ();

        
        public void Add(ImediaObject item)
        {
            mediaObjects.Add(item);
        }

        public void Clear ()
        {
            mediaObjects.Clear();
        }

        public bool  Remove(ImediaObject item)
        {
            return mediaObjects.Remove(item);
        }

        public int Count 
        {
            get { return mediaObjects.Count; }
        }

        public bool IsReadOnly
        {
            get { return mediaObjects.IsReadOnly; }
        }

        public void CopyTo (ImediaObject [] array, int arrayIndex )
        {

            mediaObjects.CopyTo(array, arrayIndex);
        }

        public bool Contains (ImediaObject item)

        {
            return mediaObjects.Contains(item);
        }

        public IEnumerator<ImediaObject> GetEnumerator()
        {
            return mediaObjects.GetEnumerator();
        }


        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

    }
}
