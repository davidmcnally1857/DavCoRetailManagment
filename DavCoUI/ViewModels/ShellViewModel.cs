﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using DavCoUI.EventModels;

namespace DavCoUI.ViewModels
{
    public class ShellViewModel : Conductor<object>, IHandle<LogOnEvent>
    {
        private IEventAggregator _events;
        private SalesViewModel _salesVM;
        private SimpleContainer _container;

        public ShellViewModel(IEventAggregator events, SalesViewModel salesVM, 
            SimpleContainer container)
        {
            _container = container;
            _events = events;
            _events.Subscribe(this);
            _salesVM = salesVM;
            ActivateItem(_container.GetInstance<LoginViewModel>());

        }

        public void Handle(LogOnEvent message)
        {
            ActivateItem(_salesVM);
            
        }
    }
}
