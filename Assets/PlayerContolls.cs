//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/PlayerContolls.inputactions
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

public partial class @PlayerContolls: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerContolls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerContolls"",
    ""maps"": [
        {
            ""name"": ""Player"",
            ""id"": ""ba927efc-a123-439d-9029-776d36a9710d"",
            ""actions"": [
                {
                    ""name"": ""Movement"",
                    ""type"": ""PassThrough"",
                    ""id"": ""6059058a-fead-47a2-a9e6-62f454a78540"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Camera"",
                    ""type"": ""PassThrough"",
                    ""id"": ""26b3de9e-306d-43d7-8bdc-6ced87bbb2be"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""Draw"",
                    ""type"": ""Button"",
                    ""id"": ""3d749587-dc43-4770-9ac4-ae35c84792e4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""slowMoation"",
                    ""type"": ""Button"",
                    ""id"": ""829bc2aa-5cbf-4967-8b22-e02165475bdb"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""attack1"",
                    ""type"": ""Button"",
                    ""id"": ""d380ae3d-b596-4c75-b180-5400d347059c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""attack2"",
                    ""type"": ""Button"",
                    ""id"": ""da707c48-4e86-4921-b981-0c9a09839c59"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""attack3"",
                    ""type"": ""Button"",
                    ""id"": ""0b7f2031-1c3c-4521-a25a-a5f06b688e9d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dica"",
                    ""type"": ""Button"",
                    ""id"": ""46f1916a-ba83-4fd0-80e6-af2db5c6e6db"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""dash"",
                    ""type"": ""Button"",
                    ""id"": ""d71f4c20-d3f7-421a-8c60-3d2df458f78f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""targetLock"",
                    ""type"": ""Button"",
                    ""id"": ""7141a25f-36c3-4346-9535-0e6b05df507d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""changeTarget"",
                    ""type"": ""Button"",
                    ""id"": ""31a67b3b-d956-409b-81e2-e78f33a0e962"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""d5ff1230-df47-44fc-8286-6d90da3bcda2"",
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
                    ""id"": ""30ea29e7-1202-474c-8083-c2bf42a5b47a"",
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
                    ""id"": ""06d16fc9-8782-416f-b55f-4df40d38a112"",
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
                    ""id"": ""c80dfab1-a10b-4750-8a41-579a31fb0367"",
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
                    ""id"": ""28deaf1b-ba6b-4e81-a3d5-e7c1e16cf75d"",
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
                    ""id"": ""b271e251-fe5d-481a-a59c-51d45ba1fecf"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Camera"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""43ed89a9-dcd7-42c1-85a0-aec48251161e"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Draw"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60995720-5da9-49c8-86cf-d19c657f58d5"",
                    ""path"": ""<Keyboard>/leftShift"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""slowMoation"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""63a05dcc-b8b2-458d-8f6e-6fca643fe446"",
                    ""path"": ""<Keyboard>/1"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0ec902cc-0621-4180-9fbd-b5a23fafde7c"",
                    ""path"": ""<Keyboard>/2"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ea048066-1f17-4391-813b-0fd8a1f1c531"",
                    ""path"": ""<Keyboard>/3"",
                    ""interactions"": ""Press(behavior=2)"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""attack3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""66e266c4-eb43-45ac-8e8d-2a3a2c52ba9f"",
                    ""path"": ""<Keyboard>/q"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dica"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""60435472-ce9a-49f7-bb17-f7ac125f3ab4"",
                    ""path"": ""<Keyboard>/ctrl"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""dash"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8ddc72f8-a5df-47a2-b9c7-7cf276e61a2f"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""targetLock"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34b3d8e2-ff3d-479c-b689-4b039f7c815f"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""changeTarget"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player
        m_Player = asset.FindActionMap("Player", throwIfNotFound: true);
        m_Player_Movement = m_Player.FindAction("Movement", throwIfNotFound: true);
        m_Player_Camera = m_Player.FindAction("Camera", throwIfNotFound: true);
        m_Player_Draw = m_Player.FindAction("Draw", throwIfNotFound: true);
        m_Player_slowMoation = m_Player.FindAction("slowMoation", throwIfNotFound: true);
        m_Player_attack1 = m_Player.FindAction("attack1", throwIfNotFound: true);
        m_Player_attack2 = m_Player.FindAction("attack2", throwIfNotFound: true);
        m_Player_attack3 = m_Player.FindAction("attack3", throwIfNotFound: true);
        m_Player_dica = m_Player.FindAction("dica", throwIfNotFound: true);
        m_Player_dash = m_Player.FindAction("dash", throwIfNotFound: true);
        m_Player_targetLock = m_Player.FindAction("targetLock", throwIfNotFound: true);
        m_Player_changeTarget = m_Player.FindAction("changeTarget", throwIfNotFound: true);
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

    // Player
    private readonly InputActionMap m_Player;
    private List<IPlayerActions> m_PlayerActionsCallbackInterfaces = new List<IPlayerActions>();
    private readonly InputAction m_Player_Movement;
    private readonly InputAction m_Player_Camera;
    private readonly InputAction m_Player_Draw;
    private readonly InputAction m_Player_slowMoation;
    private readonly InputAction m_Player_attack1;
    private readonly InputAction m_Player_attack2;
    private readonly InputAction m_Player_attack3;
    private readonly InputAction m_Player_dica;
    private readonly InputAction m_Player_dash;
    private readonly InputAction m_Player_targetLock;
    private readonly InputAction m_Player_changeTarget;
    public struct PlayerActions
    {
        private @PlayerContolls m_Wrapper;
        public PlayerActions(@PlayerContolls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement => m_Wrapper.m_Player_Movement;
        public InputAction @Camera => m_Wrapper.m_Player_Camera;
        public InputAction @Draw => m_Wrapper.m_Player_Draw;
        public InputAction @slowMoation => m_Wrapper.m_Player_slowMoation;
        public InputAction @attack1 => m_Wrapper.m_Player_attack1;
        public InputAction @attack2 => m_Wrapper.m_Player_attack2;
        public InputAction @attack3 => m_Wrapper.m_Player_attack3;
        public InputAction @dica => m_Wrapper.m_Player_dica;
        public InputAction @dash => m_Wrapper.m_Player_dash;
        public InputAction @targetLock => m_Wrapper.m_Player_targetLock;
        public InputAction @changeTarget => m_Wrapper.m_Player_changeTarget;
        public InputActionMap Get() { return m_Wrapper.m_Player; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActions set) { return set.Get(); }
        public void AddCallbacks(IPlayerActions instance)
        {
            if (instance == null || m_Wrapper.m_PlayerActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Add(instance);
            @Movement.started += instance.OnMovement;
            @Movement.performed += instance.OnMovement;
            @Movement.canceled += instance.OnMovement;
            @Camera.started += instance.OnCamera;
            @Camera.performed += instance.OnCamera;
            @Camera.canceled += instance.OnCamera;
            @Draw.started += instance.OnDraw;
            @Draw.performed += instance.OnDraw;
            @Draw.canceled += instance.OnDraw;
            @slowMoation.started += instance.OnSlowMoation;
            @slowMoation.performed += instance.OnSlowMoation;
            @slowMoation.canceled += instance.OnSlowMoation;
            @attack1.started += instance.OnAttack1;
            @attack1.performed += instance.OnAttack1;
            @attack1.canceled += instance.OnAttack1;
            @attack2.started += instance.OnAttack2;
            @attack2.performed += instance.OnAttack2;
            @attack2.canceled += instance.OnAttack2;
            @attack3.started += instance.OnAttack3;
            @attack3.performed += instance.OnAttack3;
            @attack3.canceled += instance.OnAttack3;
            @dica.started += instance.OnDica;
            @dica.performed += instance.OnDica;
            @dica.canceled += instance.OnDica;
            @dash.started += instance.OnDash;
            @dash.performed += instance.OnDash;
            @dash.canceled += instance.OnDash;
            @targetLock.started += instance.OnTargetLock;
            @targetLock.performed += instance.OnTargetLock;
            @targetLock.canceled += instance.OnTargetLock;
            @changeTarget.started += instance.OnChangeTarget;
            @changeTarget.performed += instance.OnChangeTarget;
            @changeTarget.canceled += instance.OnChangeTarget;
        }

        private void UnregisterCallbacks(IPlayerActions instance)
        {
            @Movement.started -= instance.OnMovement;
            @Movement.performed -= instance.OnMovement;
            @Movement.canceled -= instance.OnMovement;
            @Camera.started -= instance.OnCamera;
            @Camera.performed -= instance.OnCamera;
            @Camera.canceled -= instance.OnCamera;
            @Draw.started -= instance.OnDraw;
            @Draw.performed -= instance.OnDraw;
            @Draw.canceled -= instance.OnDraw;
            @slowMoation.started -= instance.OnSlowMoation;
            @slowMoation.performed -= instance.OnSlowMoation;
            @slowMoation.canceled -= instance.OnSlowMoation;
            @attack1.started -= instance.OnAttack1;
            @attack1.performed -= instance.OnAttack1;
            @attack1.canceled -= instance.OnAttack1;
            @attack2.started -= instance.OnAttack2;
            @attack2.performed -= instance.OnAttack2;
            @attack2.canceled -= instance.OnAttack2;
            @attack3.started -= instance.OnAttack3;
            @attack3.performed -= instance.OnAttack3;
            @attack3.canceled -= instance.OnAttack3;
            @dica.started -= instance.OnDica;
            @dica.performed -= instance.OnDica;
            @dica.canceled -= instance.OnDica;
            @dash.started -= instance.OnDash;
            @dash.performed -= instance.OnDash;
            @dash.canceled -= instance.OnDash;
            @targetLock.started -= instance.OnTargetLock;
            @targetLock.performed -= instance.OnTargetLock;
            @targetLock.canceled -= instance.OnTargetLock;
            @changeTarget.started -= instance.OnChangeTarget;
            @changeTarget.performed -= instance.OnChangeTarget;
            @changeTarget.canceled -= instance.OnChangeTarget;
        }

        public void RemoveCallbacks(IPlayerActions instance)
        {
            if (m_Wrapper.m_PlayerActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPlayerActions instance)
        {
            foreach (var item in m_Wrapper.m_PlayerActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PlayerActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PlayerActions @Player => new PlayerActions(this);
    public interface IPlayerActions
    {
        void OnMovement(InputAction.CallbackContext context);
        void OnCamera(InputAction.CallbackContext context);
        void OnDraw(InputAction.CallbackContext context);
        void OnSlowMoation(InputAction.CallbackContext context);
        void OnAttack1(InputAction.CallbackContext context);
        void OnAttack2(InputAction.CallbackContext context);
        void OnAttack3(InputAction.CallbackContext context);
        void OnDica(InputAction.CallbackContext context);
        void OnDash(InputAction.CallbackContext context);
        void OnTargetLock(InputAction.CallbackContext context);
        void OnChangeTarget(InputAction.CallbackContext context);
    }
}
