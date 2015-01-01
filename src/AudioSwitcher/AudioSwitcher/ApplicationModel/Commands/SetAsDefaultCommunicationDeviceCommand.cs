﻿// -----------------------------------------------------------------------
// Copyright (c) David Kean.
// -----------------------------------------------------------------------
using System;
using System.ComponentModel.Composition;
using AudioSwitcher.Audio;
using AudioSwitcher.Presentation.CommandModel;

namespace AudioSwitcher.ApplicationModel.Commands
{
    [Command(CommandId.SetAsDefaultCommunicationDevice)]
    internal class SetAsDefaultCommunicationDeviceCommand : SetAsDefaultDeviceCommand
    {
        [ImportingConstructor]
        public SetAsDefaultCommunicationDeviceCommand(AudioDeviceManager manager)
            : base(manager, AudioDeviceRole.Communications)
        {
            Text = Resources.SetAsDefaultComunicationDevice;
            Image = Resources.DefaultCommunicationsDevice;
        }
    }
}