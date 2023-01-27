//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
//     from Assets/Object/PlayerMove.inputactions
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

public partial class @PlayerMove : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerMove()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerMove"",
    ""maps"": [
        {
            ""name"": ""Box"",
            ""id"": ""fe773ca3-78b3-4f51-898b-1580db77c77b"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""e93284ba-c829-445b-bab0-e9472a7f0587"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""26681e99-6def-4cf7-a054-5b2ca963921b"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""f80730d4-c27c-4723-9629-2954fa44c206"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""9088ca50-a785-4d51-a1c9-851a310a2a3d"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""ac6729d5-c739-40aa-a865-bec84170d28e"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""376ca91e-2c2e-48a4-a91f-96af301bc034"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6a314ec7-3bce-45b9-a497-551b959c2286"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Box
        m_Box = asset.FindActionMap("Box", throwIfNotFound: true);
        m_Box_Move = m_Box.FindAction("Move", throwIfNotFound: true);
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

    // Box
    private readonly InputActionMap m_Box;
    private IBoxActions m_BoxActionsCallbackInterface;
    private readonly InputAction m_Box_Move;
    public struct BoxActions
    {
        private @PlayerMove m_Wrapper;
        public BoxActions(@PlayerMove wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Box_Move;
        public InputActionMap Get() { return m_Wrapper.m_Box; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(BoxActions set) { return set.Get(); }
        public void SetCallbacks(IBoxActions instance)
        {
            if (m_Wrapper.m_BoxActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_BoxActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_BoxActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_BoxActionsCallbackInterface.OnMove;
            }
            m_Wrapper.m_BoxActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }
        }
    }
    public BoxActions @Box => new BoxActions(this);
    public interface IBoxActions
    {
        void OnMove(InputAction.CallbackContext context);
    }
}
