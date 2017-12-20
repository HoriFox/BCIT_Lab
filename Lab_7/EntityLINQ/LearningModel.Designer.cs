﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region Метаданные связи EDM

[assembly: EdmRelationshipAttribute("LearningModel", "SubjectSubjectType", "Subject", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityLINQ.Subject), "SubjectType", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(EntityLINQ.SubjectType))]
[assembly: EdmRelationshipAttribute("LearningModel", "StudentGroupSubject", "StudentGroup", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityLINQ.StudentGroup), "Subject", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityLINQ.Subject))]
[assembly: EdmRelationshipAttribute("LearningModel", "SubjectTypeSubjectType", "SubjectType", System.Data.Metadata.Edm.RelationshipMultiplicity.ZeroOrOne, typeof(EntityLINQ.SubjectType), "SubjectType1", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(EntityLINQ.SubjectType), true)]

#endregion

namespace EntityLINQ
{
    #region Контексты
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    public partial class LearningModelContainer : ObjectContext
    {
        #region Конструкторы
    
        /// <summary>
        /// Инициализирует новый объект LearningModelContainer, используя строку соединения из раздела "LearningModelContainer" файла конфигурации приложения.
        /// </summary>
        public LearningModelContainer() : base("name=LearningModelContainer", "LearningModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта LearningModelContainer.
        /// </summary>
        public LearningModelContainer(string connectionString) : base(connectionString, "LearningModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Инициализация нового объекта LearningModelContainer.
        /// </summary>
        public LearningModelContainer(EntityConnection connection) : base(connection, "LearningModelContainer")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Разделяемые методы
    
        partial void OnContextCreated();
    
        #endregion
    
        #region Свойства ObjectSet
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<StudentGroup> StudentGroupSet
        {
            get
            {
                if ((_StudentGroupSet == null))
                {
                    _StudentGroupSet = base.CreateObjectSet<StudentGroup>("StudentGroupSet");
                }
                return _StudentGroupSet;
            }
        }
        private ObjectSet<StudentGroup> _StudentGroupSet;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<SubjectType> SubjectTypeSet
        {
            get
            {
                if ((_SubjectTypeSet == null))
                {
                    _SubjectTypeSet = base.CreateObjectSet<SubjectType>("SubjectTypeSet");
                }
                return _SubjectTypeSet;
            }
        }
        private ObjectSet<SubjectType> _SubjectTypeSet;
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        public ObjectSet<Subject> SubjectSet
        {
            get
            {
                if ((_SubjectSet == null))
                {
                    _SubjectSet = base.CreateObjectSet<Subject>("SubjectSet");
                }
                return _SubjectSet;
            }
        }
        private ObjectSet<Subject> _SubjectSet;

        #endregion

        #region Методы AddTo
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet StudentGroupSet. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToStudentGroupSet(StudentGroup studentGroup)
        {
            base.AddObject("StudentGroupSet", studentGroup);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet SubjectTypeSet. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToSubjectTypeSet(SubjectType subjectType)
        {
            base.AddObject("SubjectTypeSet", subjectType);
        }
    
        /// <summary>
        /// Устаревший метод для добавления новых объектов в набор EntitySet SubjectSet. Взамен можно использовать метод .Add связанного свойства ObjectSet&lt;T&gt;.
        /// </summary>
        public void AddToSubjectSet(Subject subject)
        {
            base.AddObject("SubjectSet", subject);
        }

        #endregion

    }

    #endregion

    #region Сущности
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LearningModel", Name="StudentGroup")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    [KnownTypeAttribute(typeof(StudentGroupSpecial))]
    public partial class StudentGroup : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта StudentGroup.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="groupName">Исходное значение свойства GroupName.</param>
        public static StudentGroup CreateStudentGroup(global::System.Int32 id, global::System.String groupName)
        {
            StudentGroup studentGroup = new StudentGroup();
            studentGroup.Id = id;
            studentGroup.GroupName = groupName;
            return studentGroup;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String GroupName
        {
            get
            {
                return _GroupName;
            }
            set
            {
                OnGroupNameChanging(value);
                ReportPropertyChanging("GroupName");
                _GroupName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("GroupName");
                OnGroupNameChanged();
            }
        }
        private global::System.String _GroupName;
        partial void OnGroupNameChanging(global::System.String value);
        partial void OnGroupNameChanged();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "StudentGroupSubject", "Subject")]
        public EntityCollection<Subject> Subject
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Subject>("LearningModel.StudentGroupSubject", "Subject");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Subject>("LearningModel.StudentGroupSubject", "Subject", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LearningModel", Name="StudentGroupSpecial")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class StudentGroupSpecial : StudentGroup
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта StudentGroupSpecial.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="groupName">Исходное значение свойства GroupName.</param>
        /// <param name="flag">Исходное значение свойства Flag.</param>
        public static StudentGroupSpecial CreateStudentGroupSpecial(global::System.Int32 id, global::System.String groupName, global::System.Boolean flag)
        {
            StudentGroupSpecial studentGroupSpecial = new StudentGroupSpecial();
            studentGroupSpecial.Id = id;
            studentGroupSpecial.GroupName = groupName;
            studentGroupSpecial.Flag = flag;
            return studentGroupSpecial;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Boolean Flag
        {
            get
            {
                return _Flag;
            }
            set
            {
                OnFlagChanging(value);
                ReportPropertyChanging("Flag");
                _Flag = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Flag");
                OnFlagChanged();
            }
        }
        private global::System.Boolean _Flag;
        partial void OnFlagChanging(global::System.Boolean value);
        partial void OnFlagChanged();

        #endregion

    
    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LearningModel", Name="Subject")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Subject : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта Subject.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="subjectName">Исходное значение свойства SubjectName.</param>
        /// <param name="value">Исходное значение свойства Value.</param>
        public static Subject CreateSubject(global::System.Int32 id, global::System.String subjectName, global::System.Int32 value)
        {
            Subject subject = new Subject();
            subject.Id = id;
            subject.SubjectName = subjectName;
            subject.Value = value;
            return subject;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String SubjectName
        {
            get
            {
                return _SubjectName;
            }
            set
            {
                OnSubjectNameChanging(value);
                ReportPropertyChanging("SubjectName");
                _SubjectName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("SubjectName");
                OnSubjectNameChanged();
            }
        }
        private global::System.String _SubjectName;
        partial void OnSubjectNameChanging(global::System.String value);
        partial void OnSubjectNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Value
        {
            get
            {
                return _Value;
            }
            set
            {
                OnValueChanging(value);
                ReportPropertyChanging("Value");
                _Value = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Value");
                OnValueChanged();
            }
        }
        private global::System.Int32 _Value;
        partial void OnValueChanging(global::System.Int32 value);
        partial void OnValueChanged();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "SubjectSubjectType", "SubjectType")]
        public SubjectType SubjectType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectSubjectType", "SubjectType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectSubjectType", "SubjectType").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SubjectType> SubjectTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectSubjectType", "SubjectType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SubjectType>("LearningModel.SubjectSubjectType", "SubjectType", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "StudentGroupSubject", "StudentGroup")]
        public EntityCollection<StudentGroup> StudentGroup
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<StudentGroup>("LearningModel.StudentGroupSubject", "StudentGroup");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<StudentGroup>("LearningModel.StudentGroupSubject", "StudentGroup", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// Нет доступной документации по метаданным.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="LearningModel", Name="SubjectType")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class SubjectType : EntityObject
    {
        #region Фабричный метод
    
        /// <summary>
        /// Создание нового объекта SubjectType.
        /// </summary>
        /// <param name="id">Исходное значение свойства Id.</param>
        /// <param name="typeName">Исходное значение свойства TypeName.</param>
        public static SubjectType CreateSubjectType(global::System.Int32 id, global::System.String typeName)
        {
            SubjectType subjectType = new SubjectType();
            subjectType.Id = id;
            subjectType.TypeName = typeName;
            return subjectType;
        }

        #endregion

        #region Свойства-примитивы
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String TypeName
        {
            get
            {
                return _TypeName;
            }
            set
            {
                OnTypeNameChanging(value);
                ReportPropertyChanging("TypeName");
                _TypeName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("TypeName");
                OnTypeNameChanged();
            }
        }
        private global::System.String _TypeName;
        partial void OnTypeNameChanging(global::System.String value);
        partial void OnTypeNameChanged();
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> SubjectTypeId
        {
            get
            {
                return _SubjectTypeId;
            }
            set
            {
                OnSubjectTypeIdChanging(value);
                ReportPropertyChanging("SubjectTypeId");
                _SubjectTypeId = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("SubjectTypeId");
                OnSubjectTypeIdChanged();
            }
        }
        private Nullable<global::System.Int32> _SubjectTypeId;
        partial void OnSubjectTypeIdChanging(Nullable<global::System.Int32> value);
        partial void OnSubjectTypeIdChanged();

        #endregion

    
        #region Свойства навигации
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "SubjectSubjectType", "Subject")]
        public EntityCollection<Subject> Subject
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Subject>("LearningModel.SubjectSubjectType", "Subject");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Subject>("LearningModel.SubjectSubjectType", "Subject", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "SubjectTypeSubjectType", "SubjectType1")]
        public EntityCollection<SubjectType> ChildSubjectTypes
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType1");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType1", value);
                }
            }
        }
    
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("LearningModel", "SubjectTypeSubjectType", "SubjectType")]
        public SubjectType ParentSubjectType
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType").Value = value;
            }
        }
        /// <summary>
        /// Нет доступной документации по метаданным.
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<SubjectType> ParentSubjectTypeReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<SubjectType>("LearningModel.SubjectTypeSubjectType", "SubjectType", value);
                }
            }
        }

        #endregion

    }

    #endregion

    
}