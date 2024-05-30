//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/XRInputActions.inputactions
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

public partial class @XRInputActions: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @XRInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""XRInputActions"",
    ""maps"": [
        {
            ""name"": ""XRActions"",
            ""id"": ""44c3132b-8216-401f-b7ed-9ac643591c20"",
            ""actions"": [
                {
                    ""name"": ""DrawAction"",
                    ""type"": ""Button"",
                    ""id"": ""ac371ceb-f3ed-4ca4-8be5-9fd168905563"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""SwitchColor"",
                    ""type"": ""Button"",
                    ""id"": ""4c03ef92-2483-45de-b9dc-eb40f1970017"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Undo"",
                    ""type"": ""Button"",
                    ""id"": ""8291c67c-a26c-4977-bd47-96c65236fc81"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""BrushSize"",
                    ""type"": ""Value"",
                    ""id"": ""c68e98f7-43ca-47db-9054-643a63b0feb7"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""ToggleUI"",
                    ""type"": ""Button"",
                    ""id"": ""dcba1a8d-63cc-442c-b139-7504f9b3c715"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""NextInstruction"",
                    ""type"": ""Button"",
                    ""id"": ""e364b105-e343-477a-908e-3eaa9cf12345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""PrevInstruction"",
                    ""type"": ""Button"",
                    ""id"": ""96ff5704-fc0a-4793-b775-feeef81538c6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""413ed99f-fce5-486f-8725-16f0107f658f"",
                    ""path"": ""<XRController>{RightHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""DrawAction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d9063a44-ecae-4ab2-9df7-160c689b58f6"",
                    ""path"": ""<XRController>{LeftHand}/triggerButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""SwitchColor"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4b156782-1b4c-49f4-82ad-1f01a94b32f0"",
                    ""path"": ""<XRController>{LeftHand}/menu"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Undo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26c74c5a-2b9b-4c81-85e9-106f61962a73"",
                    ""path"": ""<XRController>{LeftHand}/primary2DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""BrushSize"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""58d6eef1-5d27-47b3-b1f7-3603aa03bedc"",
                    ""path"": ""<XRController>{RightHand}/menuButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""ToggleUI"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c5d6cdce-8127-4011-9423-8bf4bc06f813"",
                    ""path"": ""<XRController>{RightHand}/gripButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""NextInstruction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5ce5b646-2031-41ff-b3e0-c71d24746751"",
                    ""path"": ""<XRController>{LeftHand}/{GripButton}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PrevInstruction"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // XRActions
        m_XRActions = asset.FindActionMap("XRActions", throwIfNotFound: true);
        m_XRActions_DrawAction = m_XRActions.FindAction("DrawAction", throwIfNotFound: true);
        m_XRActions_SwitchColor = m_XRActions.FindAction("SwitchColor", throwIfNotFound: true);
        m_XRActions_Undo = m_XRActions.FindAction("Undo", throwIfNotFound: true);
        m_XRActions_BrushSize = m_XRActions.FindAction("BrushSize", throwIfNotFound: true);
        m_XRActions_ToggleUI = m_XRActions.FindAction("ToggleUI", throwIfNotFound: true);
        m_XRActions_NextInstruction = m_XRActions.FindAction("NextInstruction", throwIfNotFound: true);
        m_XRActions_PrevInstruction = m_XRActions.FindAction("PrevInstruction", throwIfNotFound: true);
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

    // XRActions
    private readonly InputActionMap m_XRActions;
    private List<IXRActionsActions> m_XRActionsActionsCallbackInterfaces = new List<IXRActionsActions>();
    private readonly InputAction m_XRActions_DrawAction;
    private readonly InputAction m_XRActions_SwitchColor;
    private readonly InputAction m_XRActions_Undo;
    private readonly InputAction m_XRActions_BrushSize;
    private readonly InputAction m_XRActions_ToggleUI;
    private readonly InputAction m_XRActions_NextInstruction;
    private readonly InputAction m_XRActions_PrevInstruction;
    public struct XRActionsActions
    {
        private @XRInputActions m_Wrapper;
        public XRActionsActions(@XRInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @DrawAction => m_Wrapper.m_XRActions_DrawAction;
        public InputAction @SwitchColor => m_Wrapper.m_XRActions_SwitchColor;
        public InputAction @Undo => m_Wrapper.m_XRActions_Undo;
        public InputAction @BrushSize => m_Wrapper.m_XRActions_BrushSize;
        public InputAction @ToggleUI => m_Wrapper.m_XRActions_ToggleUI;
        public InputAction @NextInstruction => m_Wrapper.m_XRActions_NextInstruction;
        public InputAction @PrevInstruction => m_Wrapper.m_XRActions_PrevInstruction;
        public InputActionMap Get() { return m_Wrapper.m_XRActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(XRActionsActions set) { return set.Get(); }
        public void AddCallbacks(IXRActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_XRActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_XRActionsActionsCallbackInterfaces.Add(instance);
            @DrawAction.started += instance.OnDrawAction;
            @DrawAction.performed += instance.OnDrawAction;
            @DrawAction.canceled += instance.OnDrawAction;
            @SwitchColor.started += instance.OnSwitchColor;
            @SwitchColor.performed += instance.OnSwitchColor;
            @SwitchColor.canceled += instance.OnSwitchColor;
            @Undo.started += instance.OnUndo;
            @Undo.performed += instance.OnUndo;
            @Undo.canceled += instance.OnUndo;
            @BrushSize.started += instance.OnBrushSize;
            @BrushSize.performed += instance.OnBrushSize;
            @BrushSize.canceled += instance.OnBrushSize;
            @ToggleUI.started += instance.OnToggleUI;
            @ToggleUI.performed += instance.OnToggleUI;
            @ToggleUI.canceled += instance.OnToggleUI;
            @NextInstruction.started += instance.OnNextInstruction;
            @NextInstruction.performed += instance.OnNextInstruction;
            @NextInstruction.canceled += instance.OnNextInstruction;
            @PrevInstruction.started += instance.OnPrevInstruction;
            @PrevInstruction.performed += instance.OnPrevInstruction;
            @PrevInstruction.canceled += instance.OnPrevInstruction;
        }

        private void UnregisterCallbacks(IXRActionsActions instance)
        {
            @DrawAction.started -= instance.OnDrawAction;
            @DrawAction.performed -= instance.OnDrawAction;
            @DrawAction.canceled -= instance.OnDrawAction;
            @SwitchColor.started -= instance.OnSwitchColor;
            @SwitchColor.performed -= instance.OnSwitchColor;
            @SwitchColor.canceled -= instance.OnSwitchColor;
            @Undo.started -= instance.OnUndo;
            @Undo.performed -= instance.OnUndo;
            @Undo.canceled -= instance.OnUndo;
            @BrushSize.started -= instance.OnBrushSize;
            @BrushSize.performed -= instance.OnBrushSize;
            @BrushSize.canceled -= instance.OnBrushSize;
            @ToggleUI.started -= instance.OnToggleUI;
            @ToggleUI.performed -= instance.OnToggleUI;
            @ToggleUI.canceled -= instance.OnToggleUI;
            @NextInstruction.started -= instance.OnNextInstruction;
            @NextInstruction.performed -= instance.OnNextInstruction;
            @NextInstruction.canceled -= instance.OnNextInstruction;
            @PrevInstruction.started -= instance.OnPrevInstruction;
            @PrevInstruction.performed -= instance.OnPrevInstruction;
            @PrevInstruction.canceled -= instance.OnPrevInstruction;
        }

        public void RemoveCallbacks(IXRActionsActions instance)
        {
            if (m_Wrapper.m_XRActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IXRActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_XRActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_XRActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public XRActionsActions @XRActions => new XRActionsActions(this);
    public interface IXRActionsActions
    {
        void OnDrawAction(InputAction.CallbackContext context);
        void OnSwitchColor(InputAction.CallbackContext context);
        void OnUndo(InputAction.CallbackContext context);
        void OnBrushSize(InputAction.CallbackContext context);
        void OnToggleUI(InputAction.CallbackContext context);
        void OnNextInstruction(InputAction.CallbackContext context);
        void OnPrevInstruction(InputAction.CallbackContext context);
    }
}
