//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

[assembly: System.Data.Mapping.EntityViewGenerationAttribute(typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets9D1B99DA0EE547AA51E9249FE074A1C5914DC7B56EFB9EAB27CB36F04611F726))]

namespace Edm_EntityMappingGeneratedViews
{
    
    
    /// <Summary>
    /// The type contains views for EntitySets and AssociationSets that were generated at design time.
    /// </Summary>
    public sealed class ViewsForBaseEntitySets9D1B99DA0EE547AA51E9249FE074A1C5914DC7B56EFB9EAB27CB36F04611F726 : System.Data.Mapping.EntityViewContainer
    {
        
        /// <Summary>
        /// The constructor stores the views for the extents and also the hash values generated based on the metadata and mapping closure and views.
        /// </Summary>
        public ViewsForBaseEntitySets9D1B99DA0EE547AA51E9249FE074A1C5914DC7B56EFB9EAB27CB36F04611F726()
        {
            this.EdmEntityContainerName = "AuditConnection";
            this.StoreEntityContainerName = "AuditStoreContainer";
            this.HashOverMappingClosure = "6889c04c30c2f481babfa805ba4c5069437e00f6af7d250f42682e1ff7c7d43d";
            this.HashOverAllExtentViews = "1db33df420f7dfc7a9c8dbd87c6cf61a463c750b71d379ff89d1eb74f0cce055";
            this.ViewCount = 14;
        }
        
        /// <Summary>
        /// The method returns the view for the index given.
        /// </Summary>
        protected override System.Collections.Generic.KeyValuePair<string, string> GetViewAt(int index)
        {
            if ((index == 0))
            {
                return GetView0();
            }
            if ((index == 1))
            {
                return GetView1();
            }
            if ((index == 2))
            {
                return GetView2();
            }
            if ((index == 3))
            {
                return GetView3();
            }
            if ((index == 4))
            {
                return GetView4();
            }
            if ((index == 5))
            {
                return GetView5();
            }
            if ((index == 6))
            {
                return GetView6();
            }
            if ((index == 7))
            {
                return GetView7();
            }
            if ((index == 8))
            {
                return GetView8();
            }
            if ((index == 9))
            {
                return GetView9();
            }
            if ((index == 10))
            {
                return GetView10();
            }
            if ((index == 11))
            {
                return GetView11();
            }
            if ((index == 12))
            {
                return GetView12();
            }
            if ((index == 13))
            {
                return GetView13();
            }
            throw new System.IndexOutOfRangeException();
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.UserProjects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView0()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.UserProjects", @"
    SELECT VALUE -- Constructing UserProjects
        [Audit.Store.UserProjects](T1.UserProjects_UserProjectId, T1.UserProjects_ProjectId, T1.UserProjects_UserId)
    FROM (
        SELECT 
            T.UserProjectId AS UserProjects_UserProjectId, 
            T.ProjectId AS UserProjects_ProjectId, 
            T.UserId AS UserProjects_UserId, 
            True AS _from0
        FROM AuditConnection.UserProjects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.Users
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView1()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.Users", @"
    SELECT VALUE -- Constructing Users
        [Audit.Store.Users](T1.Users_UserId, T1.Users_Username, T1.Users_UserPassword, T1.Users_UserRole)
    FROM (
        SELECT 
            T.UserId AS Users_UserId, 
            T.Username AS Users_Username, 
            T.UserPassword AS Users_UserPassword, 
            T.UserRole AS Users_UserRole, 
            True AS _from0
        FROM AuditConnection.Users AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.AspectItems
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView2()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.AspectItems", @"
    SELECT VALUE -- Constructing AspectItems
        [Audit.Store.AspectItems](T1.AspectItems_AspectItemsID, T1.AspectItems_ProjectAspectID, T1.AspectItems_AspectItem)
    FROM (
        SELECT 
            T.AspectItemsID AS AspectItems_AspectItemsID, 
            T.ProjectAspectID AS AspectItems_ProjectAspectID, 
            T.AspectItem1 AS AspectItems_AspectItem, 
            True AS _from0
        FROM AuditConnection.AspectItems AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.ProjectAspects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView3()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.ProjectAspects", @"
    SELECT VALUE -- Constructing ProjectAspects
        [Audit.Store.ProjectAspects](T1.ProjectAspects_ProjectAspectsID, T1.ProjectAspects_ProjectID, T1.ProjectAspects_Aspect)
    FROM (
        SELECT 
            T.ProjectAspectsID AS ProjectAspects_ProjectAspectsID, 
            T.ProjectID AS ProjectAspects_ProjectID, 
            T.Aspect AS ProjectAspects_Aspect, 
            True AS _from0
        FROM AuditConnection.ProjectAspects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.Projects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView4()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.Projects", @"
    SELECT VALUE -- Constructing Projects
        [Audit.Store.Projects](T1.Projects_ProjectId, T1.Projects_ProjectName, T1.Projects_CreatedBy, T1.Projects_RosterWork, T1.Projects_Location, T1.Projects_ProjectNumber, T1.Projects_RosterBreak, T1.Projects_StartDate, T1.Projects_Duration)
    FROM (
        SELECT 
            T.ProjectId AS Projects_ProjectId, 
            T.ProjectName AS Projects_ProjectName, 
            T.CreatedBy AS Projects_CreatedBy, 
            T.RosterWork AS Projects_RosterWork, 
            T.Location AS Projects_Location, 
            T.ProjectNumber AS Projects_ProjectNumber, 
            T.RosterBreak AS Projects_RosterBreak, 
            T.StartDate AS Projects_StartDate, 
            T.Duration AS Projects_Duration, 
            True AS _from0
        FROM AuditConnection.Projects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.UserProjects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView5()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.UserProjects", @"
    SELECT VALUE -- Constructing UserProjects
        [Audit.UserProject](T1.UserProject_UserProjectId, T1.UserProject_ProjectId, T1.UserProject_UserId)
    FROM (
        SELECT 
            T.UserProjectId AS UserProject_UserProjectId, 
            T.ProjectId AS UserProject_ProjectId, 
            T.UserId AS UserProject_UserId, 
            True AS _from0
        FROM AuditStoreContainer.UserProjects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.Users
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView6()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.Users", @"
    SELECT VALUE -- Constructing Users
        [Audit.User](T1.User_UserId, T1.User_Username, T1.User_UserPassword, T1.User_UserRole)
    FROM (
        SELECT 
            T.UserId AS User_UserId, 
            T.Username AS User_Username, 
            T.UserPassword AS User_UserPassword, 
            T.UserRole AS User_UserRole, 
            True AS _from0
        FROM AuditStoreContainer.Users AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.AspectItems
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView7()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.AspectItems", @"
    SELECT VALUE -- Constructing AspectItems
        [Audit.AspectItem](T1.AspectItem_AspectItemsID, T1.AspectItem_ProjectAspectID, T1.AspectItem_AspectItem1)
    FROM (
        SELECT 
            T.AspectItemsID AS AspectItem_AspectItemsID, 
            T.ProjectAspectID AS AspectItem_ProjectAspectID, 
            T.AspectItem AS AspectItem_AspectItem1, 
            True AS _from0
        FROM AuditStoreContainer.AspectItems AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.ProjectAspects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView8()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.ProjectAspects", @"
    SELECT VALUE -- Constructing ProjectAspects
        [Audit.ProjectAspect](T1.ProjectAspect_ProjectAspectsID, T1.ProjectAspect_ProjectID, T1.ProjectAspect_Aspect)
    FROM (
        SELECT 
            T.ProjectAspectsID AS ProjectAspect_ProjectAspectsID, 
            T.ProjectID AS ProjectAspect_ProjectID, 
            T.Aspect AS ProjectAspect_Aspect, 
            True AS _from0
        FROM AuditStoreContainer.ProjectAspects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.Projects
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView9()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.Projects", @"
    SELECT VALUE -- Constructing Projects
        [Audit.Project](T1.Project_ProjectId, T1.Project_ProjectName, T1.Project_CreatedBy, T1.Project_RosterWork, T1.Project_Location, T1.Project_ProjectNumber, T1.Project_RosterBreak, T1.Project_StartDate, T1.Project_Duration)
    FROM (
        SELECT 
            T.ProjectId AS Project_ProjectId, 
            T.ProjectName AS Project_ProjectName, 
            T.CreatedBy AS Project_CreatedBy, 
            T.RosterWork AS Project_RosterWork, 
            T.Location AS Project_Location, 
            T.ProjectNumber AS Project_ProjectNumber, 
            T.RosterBreak AS Project_RosterBreak, 
            T.StartDate AS Project_StartDate, 
            T.Duration AS Project_Duration, 
            True AS _from0
        FROM AuditStoreContainer.Projects AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.Actions
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView10()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.Actions", @"
    SELECT VALUE -- Constructing Actions
        [Audit.Store.Actions](T1.Actions_ActionId, T1.Actions_ProjectId, T1.Actions_CreatedBy, T1.Actions_Closed, T1.Actions_Priority, T1.Actions_DueDate, T1.Actions_CreatedDate, T1.Actions_UploadedFile, T1.Actions_ActionDescription, T1.Actions_ClosedReason, T1.Actions_ClosedDate, T1.Actions_ClosedFile, T1.Actions_RaisedBy)
    FROM (
        SELECT 
            T.ActionId AS Actions_ActionId, 
            T.ProjectId AS Actions_ProjectId, 
            T.CreatedBy AS Actions_CreatedBy, 
            T.Closed AS Actions_Closed, 
            T.Priority AS Actions_Priority, 
            T.DueDate AS Actions_DueDate, 
            T.CreatedDate AS Actions_CreatedDate, 
            T.UploadedFile AS Actions_UploadedFile, 
            T.ActionDescription AS Actions_ActionDescription, 
            T.ClosedReason AS Actions_ClosedReason, 
            T.ClosedDate AS Actions_ClosedDate, 
            T.ClosedFile AS Actions_ClosedFile, 
            T.RaisedBy AS Actions_RaisedBy, 
            True AS _from0
        FROM AuditConnection.Actions AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.Actions
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView11()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.Actions", @"
    SELECT VALUE -- Constructing Actions
        [Audit.Action](T1.Action_ActionId, T1.Action_ProjectId, T1.Action_CreatedBy, T1.Action_Closed, T1.Action_Priority, T1.Action_DueDate, T1.Action_CreatedDate, T1.Action_UploadedFile, T1.Action_ActionDescription, T1.Action_ClosedReason, T1.Action_ClosedDate, T1.Action_ClosedFile, T1.Action_RaisedBy)
    FROM (
        SELECT 
            T.ActionId AS Action_ActionId, 
            T.ProjectId AS Action_ProjectId, 
            T.CreatedBy AS Action_CreatedBy, 
            T.Closed AS Action_Closed, 
            T.Priority AS Action_Priority, 
            T.DueDate AS Action_DueDate, 
            T.CreatedDate AS Action_CreatedDate, 
            T.UploadedFile AS Action_UploadedFile, 
            T.ActionDescription AS Action_ActionDescription, 
            T.ClosedReason AS Action_ClosedReason, 
            T.ClosedDate AS Action_ClosedDate, 
            T.ClosedFile AS Action_ClosedFile, 
            T.RaisedBy AS Action_RaisedBy, 
            True AS _from0
        FROM AuditStoreContainer.Actions AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditStoreContainer.Results
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView12()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditStoreContainer.Results", @"
    SELECT VALUE -- Constructing Results
        [Audit.Store.Results](T1.Results_ResultID, T1.Results_ProjectId, T1.Results_AspectItem, T1.Results_ObservationalComment, T1.Results_Satisfactory, T1.Results_ConductedBy, T1.Results_Auditees, T1.Results_WeatherObservations, T1.Results_AuditGuid, T1.Results_DateRecorded)
    FROM (
        SELECT 
            T.ResultID AS Results_ResultID, 
            T.ProjectId AS Results_ProjectId, 
            T.AspectItem AS Results_AspectItem, 
            T.ObservationalComment AS Results_ObservationalComment, 
            T.Satisfactory AS Results_Satisfactory, 
            T.ConductedBy AS Results_ConductedBy, 
            T.Auditees AS Results_Auditees, 
            T.WeatherObservations AS Results_WeatherObservations, 
            T.AuditGuid AS Results_AuditGuid, 
            T.DateRecorded AS Results_DateRecorded, 
            True AS _from0
        FROM AuditConnection.Results AS T
    ) AS T1");
        }
        
        /// <Summary>
        /// return view for AuditConnection.Results
        /// </Summary>
        private System.Collections.Generic.KeyValuePair<string, string> GetView13()
        {
            return new System.Collections.Generic.KeyValuePair<string, string>("AuditConnection.Results", @"
    SELECT VALUE -- Constructing Results
        [Audit.Result](T1.Result_ResultID, T1.Result_ProjectId, T1.Result_AspectItem, T1.Result_ObservationalComment, T1.Result_Satisfactory, T1.Result_ConductedBy, T1.Result_Auditees, T1.Result_WeatherObservations, T1.Result_AuditGuid, T1.Result_DateRecorded)
    FROM (
        SELECT 
            T.ResultID AS Result_ResultID, 
            T.ProjectId AS Result_ProjectId, 
            T.AspectItem AS Result_AspectItem, 
            T.ObservationalComment AS Result_ObservationalComment, 
            T.Satisfactory AS Result_Satisfactory, 
            T.ConductedBy AS Result_ConductedBy, 
            T.Auditees AS Result_Auditees, 
            T.WeatherObservations AS Result_WeatherObservations, 
            T.AuditGuid AS Result_AuditGuid, 
            T.DateRecorded AS Result_DateRecorded, 
            True AS _from0
        FROM AuditStoreContainer.Results AS T
    ) AS T1");
        }
    }
}
