using System;
using System.Collections.Generic;
using System.Text;

namespace ChoreBoard.Core.Models
{
    public abstract class RecurrencePatternBase : Binding.BindingObject, IRecurrencePattern
    {
        private int _frequencyInterval;
        private RolloverType _rolloverType;
        private RolloverFrom _rolloverFrom;
        private int? _maxOccurrences;
        private DateTime? _endDate;

        public RecurrencePatternBase(FrequencyType frequencyType)
        {
            FrequencyType = frequencyType;
        }

        public virtual FrequencyType FrequencyType { get; }

        public virtual int FrequencyInterval
        {
            get => _frequencyInterval;
            set => SetProperty(ref _frequencyInterval, value);
        }

        public virtual RolloverType RolloverType
        {
            get => _rolloverType;
            set => SetProperty(ref _rolloverType, value);
        }

        public virtual RolloverFrom RolloverFrom
        {
            get => _rolloverFrom;
            set => SetProperty(ref _rolloverFrom, value);
        }

        public virtual int? MaxOccurrences
        {
            get => _maxOccurrences;
            set => SetProperty(ref _maxOccurrences, value);
        }

        public virtual DateTime? EndDate
        {
            get => _endDate;
            set => SetProperty(ref _endDate, value;
        }
    }
}
