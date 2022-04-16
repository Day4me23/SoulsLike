// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/Character.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @Character : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @Character()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""Character"",
    ""maps"": [
        {
            ""name"": ""Combat"",
            ""id"": ""e4d44173-b20c-4d37-84c3-7f937547b4c9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""d548751f-9d03-47c1-8499-0a5ce4f91847"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""Value"",
                    ""id"": ""9ba2bfaa-21c6-41ed-990e-99867ff33b02"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Weapon Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""91826ec9-429e-406d-b2d8-7b080dba1932"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Weapon Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""939cf768-d840-491b-b43d-a78285144345"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Item"",
                    ""type"": ""Button"",
                    ""id"": ""58f3aaf2-f769-453f-8623-4ed88d3912dd"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""40dac5c5-558f-44ca-8d54-1710360bb255"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""RollDashJump"",
                    ""type"": ""Button"",
                    ""id"": ""8caf52a8-32ac-4546-9f74-8c998f88cada"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block/Left Weapon Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""8691674a-3226-40d6-ae8b-b226ddf9310f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Parry/Left Weapon Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""31abac2c-417f-4e00-b86c-42957da5f269"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""526cab1b-07da-4b2f-b0aa-cd9a1d9b85d7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""dd873b33-607f-4e4c-b5f3-963e0892bb3d"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""baaed475-6505-42af-9fd4-9695300bd1d8"",
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
                    ""id"": ""3cfe3983-3e48-4ee8-b7ed-5995aa761ba1"",
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
                    ""id"": ""58eae431-b885-4eb9-9c3b-b1062005597d"",
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
                    ""id"": ""c5002433-a970-430c-ad12-a11edfc95556"",
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
                    ""id"": ""75f99995-459f-4b70-84b5-248a8db89726"",
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
                    ""id"": ""ea0eb5e3-b65c-4d06-921c-9c17c59d342a"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dab53520-1071-4cbc-ac0f-0708a527f06c"",
                    ""path"": ""<Pointer>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ffd1b407-628c-4ea8-8852-fb7f16fc2169"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Weapon Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""37ebe7bf-ee1a-4496-b29e-070e0788ec68"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Weapon Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6bc97b3-bee6-4105-bb37-fa4e1c05b957"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Weapon Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8b54a7d6-09a2-421c-9c5f-f1fd7f58caba"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right Weapon Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a7189634-f59a-4ac8-8ab0-56da427b67af"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6b7d1b54-5846-42f6-b695-1dd2e2561e4e"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c2bdfa00-6d50-45ab-8563-31dcc8a42a8f"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8806cab0-8ba6-465f-a402-c32558de97df"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""05ac53f7-c34e-4a64-a285-8b44204e2f9b"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RollDashJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ec268220-5e75-4df1-99dd-4844cd11b8e0"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""RollDashJump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""952a26c9-fab9-46f8-891c-49bdd04c7315"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block/Left Weapon Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""eb462bf7-7252-4d32-b9b5-ef36c9079400"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Block/Left Weapon Light Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""049af769-4062-4f26-a885-2ddd0a04501b"",
                    ""path"": ""<Gamepad>/leftTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry/Left Weapon Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cdadf669-e276-4955-baf8-3856e8b3c82c"",
                    ""path"": ""<Keyboard>/tab"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Parry/Left Weapon Heavy Attack"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ec3cf0b-83f4-42de-8fd0-ffceb9e900aa"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""75e2d47d-b155-461b-bd97-c1b9897e056c"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Combat
        m_Combat = asset.FindActionMap("Combat", throwIfNotFound: true);
        m_Combat_Move = m_Combat.FindAction("Move", throwIfNotFound: true);
        m_Combat_Look = m_Combat.FindAction("Look", throwIfNotFound: true);
        m_Combat_RightWeaponLightAttack = m_Combat.FindAction("Right Weapon Light Attack", throwIfNotFound: true);
        m_Combat_RightWeaponHeavyAttack = m_Combat.FindAction("Right Weapon Heavy Attack", throwIfNotFound: true);
        m_Combat_UseItem = m_Combat.FindAction("Use Item", throwIfNotFound: true);
        m_Combat_Interact = m_Combat.FindAction("Interact", throwIfNotFound: true);
        m_Combat_RollDashJump = m_Combat.FindAction("RollDashJump", throwIfNotFound: true);
        m_Combat_BlockLeftWeaponLightAttack = m_Combat.FindAction("Block/Left Weapon Light Attack", throwIfNotFound: true);
        m_Combat_ParryLeftWeaponHeavyAttack = m_Combat.FindAction("Parry/Left Weapon Heavy Attack", throwIfNotFound: true);
        m_Combat_Menu = m_Combat.FindAction("Menu", throwIfNotFound: true);
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

    // Combat
    private readonly InputActionMap m_Combat;
    private ICombatActions m_CombatActionsCallbackInterface;
    private readonly InputAction m_Combat_Move;
    private readonly InputAction m_Combat_Look;
    private readonly InputAction m_Combat_RightWeaponLightAttack;
    private readonly InputAction m_Combat_RightWeaponHeavyAttack;
    private readonly InputAction m_Combat_UseItem;
    private readonly InputAction m_Combat_Interact;
    private readonly InputAction m_Combat_RollDashJump;
    private readonly InputAction m_Combat_BlockLeftWeaponLightAttack;
    private readonly InputAction m_Combat_ParryLeftWeaponHeavyAttack;
    private readonly InputAction m_Combat_Menu;
    public struct CombatActions
    {
        private @Character m_Wrapper;
        public CombatActions(@Character wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_Combat_Move;
        public InputAction @Look => m_Wrapper.m_Combat_Look;
        public InputAction @RightWeaponLightAttack => m_Wrapper.m_Combat_RightWeaponLightAttack;
        public InputAction @RightWeaponHeavyAttack => m_Wrapper.m_Combat_RightWeaponHeavyAttack;
        public InputAction @UseItem => m_Wrapper.m_Combat_UseItem;
        public InputAction @Interact => m_Wrapper.m_Combat_Interact;
        public InputAction @RollDashJump => m_Wrapper.m_Combat_RollDashJump;
        public InputAction @BlockLeftWeaponLightAttack => m_Wrapper.m_Combat_BlockLeftWeaponLightAttack;
        public InputAction @ParryLeftWeaponHeavyAttack => m_Wrapper.m_Combat_ParryLeftWeaponHeavyAttack;
        public InputAction @Menu => m_Wrapper.m_Combat_Menu;
        public InputActionMap Get() { return m_Wrapper.m_Combat; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CombatActions set) { return set.Get(); }
        public void SetCallbacks(ICombatActions instance)
        {
            if (m_Wrapper.m_CombatActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnLook;
                @RightWeaponLightAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponHeavyAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @UseItem.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnUseItem;
                @Interact.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnInteract;
                @RollDashJump.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnRollDashJump;
                @RollDashJump.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnRollDashJump;
                @RollDashJump.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnRollDashJump;
                @BlockLeftWeaponLightAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @ParryLeftWeaponHeavyAttack.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @Menu.started -= m_Wrapper.m_CombatActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_CombatActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_CombatActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_CombatActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
                @RightWeaponLightAttack.started += instance.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.performed += instance.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.canceled += instance.OnRightWeaponLightAttack;
                @RightWeaponHeavyAttack.started += instance.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.performed += instance.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.canceled += instance.OnRightWeaponHeavyAttack;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @RollDashJump.started += instance.OnRollDashJump;
                @RollDashJump.performed += instance.OnRollDashJump;
                @RollDashJump.canceled += instance.OnRollDashJump;
                @BlockLeftWeaponLightAttack.started += instance.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.performed += instance.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.canceled += instance.OnBlockLeftWeaponLightAttack;
                @ParryLeftWeaponHeavyAttack.started += instance.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.performed += instance.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.canceled += instance.OnParryLeftWeaponHeavyAttack;
                @Menu.started += instance.OnMenu;
                @Menu.performed += instance.OnMenu;
                @Menu.canceled += instance.OnMenu;
            }
        }
    }
    public CombatActions @Combat => new CombatActions(this);
    public interface ICombatActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
        void OnRightWeaponLightAttack(InputAction.CallbackContext context);
        void OnRightWeaponHeavyAttack(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnRollDashJump(InputAction.CallbackContext context);
        void OnBlockLeftWeaponLightAttack(InputAction.CallbackContext context);
        void OnParryLeftWeaponHeavyAttack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
