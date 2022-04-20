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
            ""name"": ""Player Movement"",
            ""id"": ""e4d44173-b20c-4d37-84c3-7f937547b4c9"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d548751f-9d03-47c1-8499-0a5ce4f91847"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""9ba2bfaa-21c6-41ed-990e-99867ff33b02"",
                    ""expectedControlType"": ""Vector2"",
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
                    ""path"": ""2DVector(mode=2)"",
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
                    ""processors"": ""StickDeadzone"",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dab53520-1071-4cbc-ac0f-0708a527f06c"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Player Actions"",
            ""id"": ""76ccc6e4-4136-490a-b611-b46cd4ec128d"",
            ""actions"": [
                {
                    ""name"": ""Roll"",
                    ""type"": ""Button"",
                    ""id"": ""1b87e291-4221-4025-84b6-f3c795bdea55"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""Button"",
                    ""id"": ""2380ee82-259b-4987-be19-99a615d30e8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Use Item"",
                    ""type"": ""Button"",
                    ""id"": ""8255132c-047e-4ae8-8ca5-a1aee4ba0297"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Weapon Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""1e94f0db-bc8d-45fe-a383-a65b21b4522e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Right Weapon Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""161beb86-30eb-443c-bba4-a790b6cf15ef"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""044aabbd-effc-462a-8ee9-343ef2d5f5d1"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Block/Left Weapon Light Attack"",
                    ""type"": ""Button"",
                    ""id"": ""df1e081d-0742-49eb-a98f-4d63fd1b4b40"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Parry/Left Weapon Heavy Attack"",
                    ""type"": ""Button"",
                    ""id"": ""2f462ed3-0dc9-488d-b95b-59d5e22806c5"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Menu"",
                    ""type"": ""Button"",
                    ""id"": ""65d3cd39-3588-4324-b17f-216b0ac1eb3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""40dd69b4-7e0d-4b49-a70d-b410997190e1"",
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
                    ""id"": ""352ea481-e051-463f-862f-d649a9d218da"",
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
                    ""id"": ""6ec51711-4f7a-4b97-9e57-4490158e28c9"",
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
                    ""id"": ""1f4d324c-9b3c-4ca1-afbb-9d4ad77e7f07"",
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
                    ""id"": ""4e7b9bb4-8768-46d6-94c7-47f9dfb8b09f"",
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
                    ""id"": ""c73e5db5-a55e-4d71-b4b4-a095db9f923a"",
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
                    ""id"": ""b031c7db-722c-4b5c-9a77-be2665686367"",
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
                    ""id"": ""671ca739-968d-4ebc-950d-721294abb914"",
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
                    ""id"": ""94df2642-21f3-4c3e-a291-e300be576573"",
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
                    ""id"": ""b9094083-db01-4977-ab9d-3ccce6672074"",
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
                    ""id"": ""3969da1a-784d-482e-8a98-e39e4e767154"",
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
                    ""id"": ""d053157c-b8ea-4c1c-8209-d0108fd64d5e"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Menu"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f21dce8e-05d1-4043-95b4-a1f0127832b7"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""b2627b3b-328e-485d-aa33-cbbcd02bd215"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Tap"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Roll"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""fae44f18-eed4-438f-b5fc-495ebc213bf4"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a4bca618-01c2-4c49-964f-9751f4ef90c5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": ""Hold"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""17e163be-8836-4385-843e-0563e2bcbf56"",
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
                    ""id"": ""f0e5c3d7-369d-4d84-881a-dbb4182920fc"",
                    ""path"": ""<Keyboard>/r"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Use Item"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Player Movement
        m_PlayerMovement = asset.FindActionMap("Player Movement", throwIfNotFound: true);
        m_PlayerMovement_Move = m_PlayerMovement.FindAction("Move", throwIfNotFound: true);
        m_PlayerMovement_Look = m_PlayerMovement.FindAction("Look", throwIfNotFound: true);
        // Player Actions
        m_PlayerActions = asset.FindActionMap("Player Actions", throwIfNotFound: true);
        m_PlayerActions_Roll = m_PlayerActions.FindAction("Roll", throwIfNotFound: true);
        m_PlayerActions_Sprint = m_PlayerActions.FindAction("Sprint", throwIfNotFound: true);
        m_PlayerActions_UseItem = m_PlayerActions.FindAction("Use Item", throwIfNotFound: true);
        m_PlayerActions_RightWeaponLightAttack = m_PlayerActions.FindAction("Right Weapon Light Attack", throwIfNotFound: true);
        m_PlayerActions_RightWeaponHeavyAttack = m_PlayerActions.FindAction("Right Weapon Heavy Attack", throwIfNotFound: true);
        m_PlayerActions_Interact = m_PlayerActions.FindAction("Interact", throwIfNotFound: true);
        m_PlayerActions_BlockLeftWeaponLightAttack = m_PlayerActions.FindAction("Block/Left Weapon Light Attack", throwIfNotFound: true);
        m_PlayerActions_ParryLeftWeaponHeavyAttack = m_PlayerActions.FindAction("Parry/Left Weapon Heavy Attack", throwIfNotFound: true);
        m_PlayerActions_Menu = m_PlayerActions.FindAction("Menu", throwIfNotFound: true);
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

    // Player Movement
    private readonly InputActionMap m_PlayerMovement;
    private IPlayerMovementActions m_PlayerMovementActionsCallbackInterface;
    private readonly InputAction m_PlayerMovement_Move;
    private readonly InputAction m_PlayerMovement_Look;
    public struct PlayerMovementActions
    {
        private @Character m_Wrapper;
        public PlayerMovementActions(@Character wrapper) { m_Wrapper = wrapper; }
        public InputAction @Move => m_Wrapper.m_PlayerMovement_Move;
        public InputAction @Look => m_Wrapper.m_PlayerMovement_Look;
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerMovementActions instance)
        {
            if (m_Wrapper.m_PlayerMovementActionsCallbackInterface != null)
            {
                @Move.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Move.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnMove;
                @Look.started -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.performed -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
                @Look.canceled -= m_Wrapper.m_PlayerMovementActionsCallbackInterface.OnLook;
            }
            m_Wrapper.m_PlayerMovementActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Look.started += instance.OnLook;
                @Look.performed += instance.OnLook;
                @Look.canceled += instance.OnLook;
            }
        }
    }
    public PlayerMovementActions @PlayerMovement => new PlayerMovementActions(this);

    // Player Actions
    private readonly InputActionMap m_PlayerActions;
    private IPlayerActionsActions m_PlayerActionsActionsCallbackInterface;
    private readonly InputAction m_PlayerActions_Roll;
    private readonly InputAction m_PlayerActions_Sprint;
    private readonly InputAction m_PlayerActions_UseItem;
    private readonly InputAction m_PlayerActions_RightWeaponLightAttack;
    private readonly InputAction m_PlayerActions_RightWeaponHeavyAttack;
    private readonly InputAction m_PlayerActions_Interact;
    private readonly InputAction m_PlayerActions_BlockLeftWeaponLightAttack;
    private readonly InputAction m_PlayerActions_ParryLeftWeaponHeavyAttack;
    private readonly InputAction m_PlayerActions_Menu;
    public struct PlayerActionsActions
    {
        private @Character m_Wrapper;
        public PlayerActionsActions(@Character wrapper) { m_Wrapper = wrapper; }
        public InputAction @Roll => m_Wrapper.m_PlayerActions_Roll;
        public InputAction @Sprint => m_Wrapper.m_PlayerActions_Sprint;
        public InputAction @UseItem => m_Wrapper.m_PlayerActions_UseItem;
        public InputAction @RightWeaponLightAttack => m_Wrapper.m_PlayerActions_RightWeaponLightAttack;
        public InputAction @RightWeaponHeavyAttack => m_Wrapper.m_PlayerActions_RightWeaponHeavyAttack;
        public InputAction @Interact => m_Wrapper.m_PlayerActions_Interact;
        public InputAction @BlockLeftWeaponLightAttack => m_Wrapper.m_PlayerActions_BlockLeftWeaponLightAttack;
        public InputAction @ParryLeftWeaponHeavyAttack => m_Wrapper.m_PlayerActions_ParryLeftWeaponHeavyAttack;
        public InputAction @Menu => m_Wrapper.m_PlayerActions_Menu;
        public InputActionMap Get() { return m_Wrapper.m_PlayerActions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PlayerActionsActions set) { return set.Get(); }
        public void SetCallbacks(IPlayerActionsActions instance)
        {
            if (m_Wrapper.m_PlayerActionsActionsCallbackInterface != null)
            {
                @Roll.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Roll.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRoll;
                @Sprint.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprint;
                @Sprint.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprint;
                @Sprint.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnSprint;
                @UseItem.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUseItem;
                @UseItem.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUseItem;
                @UseItem.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnUseItem;
                @RightWeaponLightAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponLightAttack;
                @RightWeaponHeavyAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnRightWeaponHeavyAttack;
                @Interact.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnInteract;
                @BlockLeftWeaponLightAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @BlockLeftWeaponLightAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnBlockLeftWeaponLightAttack;
                @ParryLeftWeaponHeavyAttack.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @ParryLeftWeaponHeavyAttack.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnParryLeftWeaponHeavyAttack;
                @Menu.started -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMenu;
                @Menu.performed -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMenu;
                @Menu.canceled -= m_Wrapper.m_PlayerActionsActionsCallbackInterface.OnMenu;
            }
            m_Wrapper.m_PlayerActionsActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Roll.started += instance.OnRoll;
                @Roll.performed += instance.OnRoll;
                @Roll.canceled += instance.OnRoll;
                @Sprint.started += instance.OnSprint;
                @Sprint.performed += instance.OnSprint;
                @Sprint.canceled += instance.OnSprint;
                @UseItem.started += instance.OnUseItem;
                @UseItem.performed += instance.OnUseItem;
                @UseItem.canceled += instance.OnUseItem;
                @RightWeaponLightAttack.started += instance.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.performed += instance.OnRightWeaponLightAttack;
                @RightWeaponLightAttack.canceled += instance.OnRightWeaponLightAttack;
                @RightWeaponHeavyAttack.started += instance.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.performed += instance.OnRightWeaponHeavyAttack;
                @RightWeaponHeavyAttack.canceled += instance.OnRightWeaponHeavyAttack;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
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
    public PlayerActionsActions @PlayerActions => new PlayerActionsActions(this);
    public interface IPlayerMovementActions
    {
        void OnMove(InputAction.CallbackContext context);
        void OnLook(InputAction.CallbackContext context);
    }
    public interface IPlayerActionsActions
    {
        void OnRoll(InputAction.CallbackContext context);
        void OnSprint(InputAction.CallbackContext context);
        void OnUseItem(InputAction.CallbackContext context);
        void OnRightWeaponLightAttack(InputAction.CallbackContext context);
        void OnRightWeaponHeavyAttack(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnBlockLeftWeaponLightAttack(InputAction.CallbackContext context);
        void OnParryLeftWeaponHeavyAttack(InputAction.CallbackContext context);
        void OnMenu(InputAction.CallbackContext context);
    }
}
