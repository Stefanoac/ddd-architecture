﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Entities
{
    public abstract class BaseEntity
    {
        private DateTime? _createAt;

        [Key]
        public Guid Id { get; set; }

        public DateTime? CreatedAt
        {
            get { return _createAt; }
            set { _createAt = (value == null ? DateTime.UtcNow : value); }
        }

        public DateTime UpdateAt { get; set; }

    }
}
