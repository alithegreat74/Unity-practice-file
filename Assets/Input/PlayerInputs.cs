//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.4.4
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

public partial class @PlayerInputs : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""CharacterContorls"",
            ""id"": ""55e2ea23-a5e5-4141-8c6d-ab867c8382fc"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""0a1ccc35-8f04-4682-b35c-253e7b75daeb"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": ""NormalizeVector2"",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""78e056fb-e0bb-433c-9de5-139ffe2a3e41"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""413b38d1-3970-406e-a1e3-7756bac8fd2f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""e8926fec-2402-4ee4-a447-c0ae51c18596"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""01a33da9-ffe6-41d9-98c0-30eb753a837c"",
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
                    ""id"": ""5ffe1d07-7663-4cd6-81b1-3b85ecbed138"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6cd8284d-a8f7-4db3-af58-ffd0e2fc78d4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""077a7b22-2aff-443f-836d-e2d4844b743a"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""bd190551-5942-445a-b75e-d4b8ead41960"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""b9a40743-3ae5-4973-a1db-be528374c7bb"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6eb23a12-020d-4c76-9179-3e1df859f571"",
                    ""path"": ""<Keyboard>/alt"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b8ae5977-7eba-450e-be22-1b4274f2688c"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // CharacterContorls
        m_CharacterContorls = asset.FindActionMap("CharacterContorls", throwIfNotFound: true);
        m_CharacterContorls_Move = m_CharacterContorls.FindAction("Move", throwIfNotFound: true);
        m_CharacterContorls_Run = m_CharacterContorls.FindAction("Run", throwIfNotFound: true);
        m_CharacterContorls_Jump = m_CharacterContorls.FindAction("Jump", throwIfNotFound: true);
        m_CharacterContorls_Roll = m_CharacterContorls.FindAction("Roll", throwIfNotFound: true);
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

    // CharacterContorls
    private readonly InputActionMap m_CharacterContorls;
    private ICharacterContorlsActions m_CharacterContorlsActionsCallbackInterface;
    private readonly InputAction m_CharacterContorls_Move;
    private readonly InputAction m_CharacterContorls_Run;
    private readonly InputAction m_CharacterContorls_Jump;
    private readonly InputAction m_CharacterContorls_Roll;
    public struct CharacterContorlsActions
    {
        private @PlayerInputs m_Wrapper;
        public CharacterContorlsActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_CharacterContorls_Move;
        public InputAction @Run => m_Wrapper.m_CharacterContorls_Run;
        public InputAction @Jump => m_Wrapper.m_CharacterContorls_Jump;
        public InputAction @Roll => m_Wrapper.m_CharacterContorls_Roll;
        public InputActionMap Get() { return m_Wrapper.m_CharacterContorls; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CharacterContorlsActions set) { return set.Get(); }
        public void SetCallbacks(ICharacterContorlsActions instance)
        {
            if (m_Wrapper.m_CharacterContorlsActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnMove;
                @Run.started -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRun;
                @Jump.started -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnJump;
                @Roll.started -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_CharacterContorlsActionsCallbackInterface.OnRoll;
            }
            m_Wrapper.m_CharacterContorlsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
            }
        }
    }
    public CharacterContorlsActions @CharacterContorls => new CharacterContorlsActions(this);
    public interface ICharacterContorlsActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnRoll(InputAction.CallbackContext context);
    }
}