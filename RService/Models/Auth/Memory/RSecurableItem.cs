﻿using RSecurityBackend.Models.Auth.Memory;

namespace RService.Models.Auth.Memory
{
    /// <summary>
    /// specific forms and permission
    /// </summary>
    public class RSecurableItem : SecurableItem
    {

        /// <summary>
        /// list of forms and their permissions
        /// </summary>
        public new static SecurableItem[] Items
        {
            get
            {
                List<SecurableItem> lst = new List<SecurableItem>(SecurableItem.Items);
                //lst.AddRange(new permissions);
                return lst.ToArray();
            }
        }

        /// <summary>
        /// workspace forms and their permissions
        /// </summary>
        public new static SecurableItem[] WorkspaceItems
        {
            get
            {
                List<SecurableItem> lst = new List<SecurableItem>(SecurableItem.WorkspaceItems);
                //lst.AddRange(new permissions);
                return lst.ToArray();
            }
        }
    }
}
