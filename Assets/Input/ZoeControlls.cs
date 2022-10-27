//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.3
//     from Assets/Input/ZoeControlls.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @ZoeControlls : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @ZoeControlls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""ZoeControlls"",
    ""maps"": [
        {
            ""name"": ""Zoe Player"",
            ""id"": ""7748f09e-a176-41d1-a35a-44b697e40f7d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""91c05095-4fc8-436b-8ff6-36cb35633985"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""f3b91b19-d16b-4fd8-8686-974fd271fe0d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Submit"",
                    ""type"": ""Button"",
                    ""id"": ""d16d8406-a639-4e28-a794-48d71160b41b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Skip"",
                    ""type"": ""Button"",
                    ""id"": ""862e0413-d0ae-4093-80d8-2c82f0d48c3d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""45fbf130-12c2-42da-88ca-35ab1381edf7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Show Help"",
                    ""type"": ""Button"",
                    ""id"": ""2c1ee575-3e8f-41a0-858a-80bee8810ee0"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""4167d1d1-d779-44de-ad7a-6de48e596855"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""939e9a07-8160-42ed-8bd1-a92b22c2648f"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""bc8068e7-df27-4fca-99db-d222447d4a1e"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""de774b47-c336-40d4-9e36-4f95fd90843d"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""913341e0-ef28-4723-9160-96e802b18f71"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""Arrows"",
                    ""id"": ""42f8039a-9f7d-4dc5-8f52-ff9037f7a788"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9f98de0e-e164-41ea-b745-6cccf04a4d69"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""a9be6ecb-bfbd-4d6a-9f1a-06285d1f376c"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""91a81e48-f34c-43de-b4ce-447952d9af27"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bc86dcad-d902-41f7-a4cc-f28736103d45"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""01fba9da-132f-4b13-9263-ce098c71bc45"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""efcb342a-5e46-4b11-a9d8-8120b7ace09b"",
                    ""path"": ""<Keyboard>/x"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Submit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""668fa3f7-f030-410d-a0be-6e4d21fd8cb1"",
                    ""path"": ""<Keyboard>/c"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Skip"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""855362c9-021b-4138-89e8-e9719580248b"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f0f19175-e325-425a-a8c0-5f260cbb56e9"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Mouse + Keyboard;Keyboard"",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""82331efb-8531-475a-96e2-fcc910f3f361"",
                    ""path"": ""<Keyboard>/h"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;Mouse + Keyboard"",
                    ""action"": ""Show Help"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Mouse + Keyboard"",
            ""bindingGroup"": ""Mouse + Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Gamepad"",
            ""bindingGroup"": ""Gamepad"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Zoe Player
        m_ZoePlayer = asset.FindActionMap("Zoe Player", throwIfNotFound: true);
        m_ZoePlayer_Movement = m_ZoePlayer.FindAction("Movement", throwIfNotFound: true);
        m_ZoePlayer_Interact = m_ZoePlayer.FindAction("Interact", throwIfNotFound: true);
        m_ZoePlayer_Submit = m_ZoePlayer.FindAction("Submit", throwIfNotFound: true);
        m_ZoePlayer_Skip = m_ZoePlayer.FindAction("Skip", throwIfNotFound: true);
        m_ZoePlayer_Menu = m_ZoePlayer.FindAction("Menu", throwIfNotFound: true);
        m_ZoePlayer_ShowHelp = m_ZoePlayer.FindAction("Show Help", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }
    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }
    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Zoe Player
    private readonly InputActionMap m_ZoePlayer;
    private IZoePlayerActions m_ZoePlayerActionsCallbackInterface;
    private readonly InputAction m_ZoePlayer_Movement;
    private readonly InputAction m_ZoePlayer_Interact;
    private readonly InputAction m_ZoePlayer_Submit;
    private readonly InputAction m_ZoePlayer_Skip;
    private readonly InputAction m_ZoePlayer_Menu;
    private readonly InputAction m_ZoePlayer_ShowHelp;
    public struct ZoePlayerActions
    {
        private @ZoeControlls m_Wrapper;
        public ZoePlayerActions(@ZoeControlls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_ZoePlayer_Movement;
        public InputAction @Interact => m_Wrapper.m_ZoePlayer_Interact;
        public InputAction @Submit => m_Wrapper.m_ZoePlayer_Submit;
        public InputAction @Skip => m_Wrapper.m_ZoePlayer_Skip;
        public InputAction @Menu => m_Wrapper.m_ZoePlayer_Menu;
        public InputAction @ShowHelp => m_Wrapper.m_ZoePlayer_ShowHelp;
        public InputActionMap Get() { return m_Wrapper.m_ZoePlayer; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ZoePlayerActions set) { return set.Get(); }
        public void SetCallbacks(IZoePlayerActions instance)
        {
            if (m_Wrapper.m_ZoePlayerActionsCallbackInterface != null)
            {
                @Movement.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMovement;
                @Movement.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMovement;
                @Movement.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMovement;
                @Interact.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnInteract;
                @Submit.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSubmit;
                @Submit.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSubmit;
                @Submit.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSubmit;
                @Skip.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSkip;
                @Skip.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSkip;
                @Skip.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnSkip;
                @Menu.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnMenu;
                @ShowHelp.started -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnShowHelp;
                @ShowHelp.performed -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnShowHelp;
                @ShowHelp.canceled -= m_Wrapper.m_ZoePlayerActionsCallbackInterface.OnShowHelp;
            }
            m_Wrapper.m_ZoePlayerActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Movement.started += instance.OnMovement;
                @Movement.performed += instance.OnMovement;
                @Movement.canceled += instance.OnMovement;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @Submit.started += instance.OnSubmit;
                @Submit.performed += instance.OnSubmit;
                @Submit.canceled += instance.OnSubmit;
                @Skip.started += instance.OnSkip;
                @Skip.performed += instance.OnSkip;
                @Skip.canceled += instance.OnSkip;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
                @ShowHelp.started += instance.OnShowHelp;
                @ShowHelp.performed += instance.OnShowHelp;
                @ShowHelp.canceled += instance.OnShowHelp;
            }
        }
    }
    public ZoePlayerActions @ZoePlayer => new ZoePlayerActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_MouseKeyboardSchemeIndex = -1;
    public InputControlScheme MouseKeyboardScheme
    {
        get
        {
            if (m_MouseKeyboardSchemeIndex == -1) m_MouseKeyboardSchemeIndex = asset.FindControlSchemeIndex("Mouse + Keyboard");
            return asset.controlSchemes[m_MouseKeyboardSchemeIndex];
        }
    }
    private int m_GamepadSchemeIndex = -1;
    public InputControlScheme GamepadScheme
    {
        get
        {
            if (m_GamepadSchemeIndex == -1) m_GamepadSchemeIndex = asset.FindControlSchemeIndex("Gamepad");
            return asset.controlSchemes[m_GamepadSchemeIndex];
        }
    }
    public interface IZoePlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnSubmit(InputAction.CallbackContext context);
        void OnSkip(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
        void OnShowHelp(InputAction.CallbackContext context);
    }
}
