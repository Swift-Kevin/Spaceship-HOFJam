//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.8.2
//     from Assets/Input/PlayerInputs.inputactions
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
using UnityEngine;

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""General"",
            ""id"": ""5edc0ee3-280f-4778-9bbe-78496eacf9f9"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""Value"",
                    ""id"": ""493cc9c4-f909-4e5f-9e8c-9162996b02ef"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Looking"",
                    ""type"": ""Value"",
                    ""id"": ""ec8a58b0-3b5c-4c8b-8fb6-c8143c7f9f48"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ZRoll"",
                    ""type"": ""Value"",
                    ""id"": ""d1137433-f157-427a-93f4-fd4ebeea6446"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""0c2f26db-fac0-414d-8e53-7bf981e86547"",
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
                    ""id"": ""e81990fe-a0df-4388-b83e-ad4b7db71c57"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""18130ed6-2a22-4fca-8427-0d51bd0cb066"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""b9907621-577c-4a7b-b419-6eedbbd17616"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""83d38819-9d09-451b-8203-fc951b30e75d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""56054491-7746-488a-854c-a80055084d2b"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movement"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ce116bfb-e231-4e14-8dec-3ccaede1b713"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc29da12-081b-42fd-b203-f098304f9821"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Looking"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""6d253c75-e7b8-46c1-8145-6b8cffbbc901"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZRoll"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""5e92c6fb-70f6-471b-9e6c-143688dfc02f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""bf28dd3b-ab88-4737-a402-774e9659c899"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ZRoll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        },
        {
            ""name"": ""UI"",
            ""id"": ""6f706bce-408d-4a50-a212-9a5b0dec442a"",
            ""actions"": [
                {
                    ""name"": ""PauseToggle"",
                    ""type"": ""Button"",
                    ""id"": ""bc514ac1-3be8-4092-9a05-3a3aa2401593"",
                    ""expectedControlType"": """",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""4463ad51-caca-431a-88df-f3f830f04d72"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PauseToggle"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // General
        m_General = asset.FindActionMap("General", throwIfNotFound: true);
        m_General_Movement = m_General.FindAction("Movement", throwIfNotFound: true);
        m_General_Looking = m_General.FindAction("Looking", throwIfNotFound: true);
        m_General_ZRoll = m_General.FindAction("ZRoll", throwIfNotFound: true);
        // UI
        m_UI = asset.FindActionMap("UI", throwIfNotFound: true);
        m_UI_PauseToggle = m_UI.FindAction("PauseToggle", throwIfNotFound: true);
    }

    ~@PlayerInputs()
    {
        Debug.Assert(!m_General.enabled, "This will cause a leak and performance issues, PlayerInputs.General.Disable() has not been called.");
        Debug.Assert(!m_UI.enabled, "This will cause a leak and performance issues, PlayerInputs.UI.Disable() has not been called.");
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

    // General
    private readonly InputActionMap m_General;
    private List<IGeneralActions> m_GeneralActionsCallbackInterfaces = new List<IGeneralActions>();
    private readonly InputAction m_General_Movement;
    private readonly InputAction m_General_Looking;
    private readonly InputAction m_General_ZRoll;
    public struct GeneralActions
    {
        private @PlayerInputs m_Wrapper;
        public GeneralActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_General_Movement;
        public InputAction @Looking => m_Wrapper.m_General_Looking;
        public InputAction @ZRoll => m_Wrapper.m_General_ZRoll;
        public InputActionMap Get() { return m_Wrapper.m_General; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GeneralActions set) { return set.Get(); }
        public void AddCallbacks(IGeneralActions instance)
        {
            if (instance == null || m_Wrapper.m_GeneralActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_GeneralActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Looking.started += instance.OnLooking;
            @Looking.performed += instance.OnLooking;
            @Looking.canceled += instance.OnLooking;
            @ZRoll.started += instance.OnZRoll;
            @ZRoll.performed += instance.OnZRoll;
            @ZRoll.canceled += instance.OnZRoll;
        }

        private void UnregisterCallbacks(IGeneralActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Looking.started -= instance.OnLooking;
            @Looking.performed -= instance.OnLooking;
            @Looking.canceled -= instance.OnLooking;
            @ZRoll.started -= instance.OnZRoll;
            @ZRoll.performed -= instance.OnZRoll;
            @ZRoll.canceled -= instance.OnZRoll;
        }

        public void RemoveCallbacks(IGeneralActions instance)
        {
            if (m_Wrapper.m_GeneralActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IGeneralActions instance)
        {
            foreach (var item in m_Wrapper.m_GeneralActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_GeneralActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public GeneralActions @General => new GeneralActions(this);

    // UI
    private readonly InputActionMap m_UI;
    private List<IUIActions> m_UIActionsCallbackInterfaces = new List<IUIActions>();
    private readonly InputAction m_UI_PauseToggle;
    public struct UIActions
    {
        private @PlayerInputs m_Wrapper;
        public UIActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @PauseToggle => m_Wrapper.m_UI_PauseToggle;
        public InputActionMap Get() { return m_Wrapper.m_UI; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UIActions set) { return set.Get(); }
        public void AddCallbacks(IUIActions instance)
        {
            if (instance == null || m_Wrapper.m_UIActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_UIActionsCallbackInterfaces.Add(instance);
            @PauseToggle.started += instance.OnPauseToggle;
            @PauseToggle.performed += instance.OnPauseToggle;
            @PauseToggle.canceled += instance.OnPauseToggle;
        }

        private void UnregisterCallbacks(IUIActions instance)
        {
            @PauseToggle.started -= instance.OnPauseToggle;
            @PauseToggle.performed -= instance.OnPauseToggle;
            @PauseToggle.canceled -= instance.OnPauseToggle;
        }

        public void RemoveCallbacks(IUIActions instance)
        {
            if (m_Wrapper.m_UIActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IUIActions instance)
        {
            foreach (var item in m_Wrapper.m_UIActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_UIActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public UIActions @UI => new UIActions(this);
    public interface IGeneralActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnLooking(InputAction.CallbackContext context);
        void OnZRoll(InputAction.CallbackContext context);
    }
    public interface IUIActions
    {
        void OnPauseToggle(InputAction.CallbackContext context);
    }
}
