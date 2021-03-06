﻿using System;
using System.ComponentModel;

namespace PowerArgs.Cli
{
    public class PropertyChangedSubscription : Subscription
    {
        public Action ChangeListener { get; private set; }
        public string PropertyName { get; private set; }
        public PropertyChangedSubscription(string propertyName, Action changeListener, Action<PropertyChangedSubscription> unsubscribeCallback)
        {
            this.PropertyName = propertyName;
            this.ChangeListener = changeListener;
            this.unsubscribeHandler = ()=>
            {
                unsubscribeCallback(this);
            } ;
        }
    }
}
