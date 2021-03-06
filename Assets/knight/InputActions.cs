// GENERATED AUTOMATICALLY FROM 'Assets/knight/InputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @InputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputActions"",
    ""maps"": [
        {
            ""name"": ""Knight"",
            ""id"": ""10b3513a-4b2d-4845-b950-3d0ca65e6948"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""2468258a-e6d4-44ac-885d-a99a5473ace5"",
                    ""expectedControlType"": ""Dpad"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""da4d1257-e954-4fbf-af89-69aeefff99c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CallCat"",
                    ""type"": ""Button"",
                    ""id"": ""7f787cbe-dfcf-4f15-9243-9a25442a05a1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Run"",
                    ""type"": ""Button"",
                    ""id"": ""0f75be69-947c-41c5-8d86-01089dbec801"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""2a8b2245-d615-427d-8495-eef3f274d938"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""612a75b4-145f-4aaa-bcd6-3be7b333bae3"",
                    ""path"": ""<Touchscreen>/primaryTouch/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""phone"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ef3f4c9e-448f-4b2c-aa2f-ec58d64a64f8"",
                    ""path"": ""<Touchscreen>/primaryTouch/tap"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""phone"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c3d08c73-2c91-4c0a-9469-ea02bb5bf967"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""CallCat"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""keyboard"",
                    ""id"": ""80297673-aae9-4073-83d9-0f7c886e6579"",
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
                    ""id"": ""8a16bb60-89af-42ad-82fd-db09aef80964"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""b66cb31c-40b7-409f-a652-e1904aafc555"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""2c957448-a2d7-402d-9ccb-e08ab9447588"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a3c77740-daff-41bc-ba63-211e337ad216"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""0616ea6b-a980-48b6-8240-c8005f50e7e7"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""(AZERTY) keyboard and mouse"",
                    ""action"": ""Run"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""(AZERTY) keyboard and mouse"",
            ""bindingGroup"": ""(AZERTY) keyboard and mouse"",
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
                },
                {
                    ""devicePath"": ""<VirtualMouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""phone"",
            ""bindingGroup"": ""phone"",
            ""devices"": [
                {
                    ""devicePath"": ""<Touchscreen>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Knight
        m_Knight = asset.FindActionMap("Knight", throwIfNotFound: true);
        m_Knight_Move = m_Knight.FindAction("Move", throwIfNotFound: true);
        m_Knight_Jump = m_Knight.FindAction("Jump", throwIfNotFound: true);
        m_Knight_CallCat = m_Knight.FindAction("CallCat", throwIfNotFound: true);
        m_Knight_Run = m_Knight.FindAction("Run", throwIfNotFound: true);
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

    // Knight
    private readonly InputActionMap m_Knight;
    private IKnightActions m_KnightActionsCallbackInterface;
    private readonly InputAction m_Knight_Move;
    private readonly InputAction m_Knight_Jump;
    private readonly InputAction m_Knight_CallCat;
    private readonly InputAction m_Knight_Run;
    public struct KnightActions
    {
        private @InputActions m_Wrapper;
        public KnightActions(@InputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Knight_Move;
        public InputAction @Jump => m_Wrapper.m_Knight_Jump;
        public InputAction @CallCat => m_Wrapper.m_Knight_CallCat;
        public InputAction @Run => m_Wrapper.m_Knight_Run;
        public InputActionMap Get() { return m_Wrapper.m_Knight; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KnightActions set) { return set.Get(); }
        public void SetCallbacks(IKnightActions instance)
        {
            if (m_Wrapper.m_KnightActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_KnightActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_KnightActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_KnightActionsCallbackInterface.OnMove;
                @Jump.started -= m_Wrapper.m_KnightActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_KnightActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_KnightActionsCallbackInterface.OnJump;
                @CallCat.started -= m_Wrapper.m_KnightActionsCallbackInterface.OnCallCat;
                @CallCat.performed -= m_Wrapper.m_KnightActionsCallbackInterface.OnCallCat;
                @CallCat.canceled -= m_Wrapper.m_KnightActionsCallbackInterface.OnCallCat;
                @Run.started -= m_Wrapper.m_KnightActionsCallbackInterface.OnRun;
                @Run.performed -= m_Wrapper.m_KnightActionsCallbackInterface.OnRun;
                @Run.canceled -= m_Wrapper.m_KnightActionsCallbackInterface.OnRun;
            }
            m_Wrapper.m_KnightActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @CallCat.started += instance.OnCallCat;
                @CallCat.performed += instance.OnCallCat;
                @CallCat.canceled += instance.OnCallCat;
                @Run.started += instance.OnRun;
                @Run.performed += instance.OnRun;
                @Run.canceled += instance.OnRun;
            }
        }
    }
    public KnightActions @Knight => new KnightActions(this);
    private int m_AZERTYkeyboardandmouseSchemeIndex = -1;
    public InputControlScheme AZERTYkeyboardandmouseScheme
    {
        get
        {
            if (m_AZERTYkeyboardandmouseSchemeIndex == -1) m_AZERTYkeyboardandmouseSchemeIndex = asset.FindControlSchemeIndex("(AZERTY) keyboard and mouse");
            return asset.controlSchemes[m_AZERTYkeyboardandmouseSchemeIndex];
        }
    }
    private int m_phoneSchemeIndex = -1;
    public InputControlScheme phoneScheme
    {
        get
        {
            if (m_phoneSchemeIndex == -1) m_phoneSchemeIndex = asset.FindControlSchemeIndex("phone");
            return asset.controlSchemes[m_phoneSchemeIndex];
        }
    }
    public interface IKnightActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnJump(InputAction.CallbackContext context);
        void OnCallCat(InputAction.CallbackContext context);
        void OnRun(InputAction.CallbackContext context);
    }
}
