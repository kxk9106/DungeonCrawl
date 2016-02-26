using UnityEngine;
using System.Collections;

public class GunController : MonoBehaviour {
	
	public Transform weaponHold;
	public Gun startingGun;
	Gun equippedGun;
	
	void Awake() {
		if (startingGun != null) {
			EquipGun(startingGun);
		}
	}
	
	public void EquipGun(Gun gunToEquip) {
		if (equippedGun != null) {
			Destroy(equippedGun.gameObject);
		}
		equippedGun = Instantiate (gunToEquip, weaponHold.position,weaponHold.rotation) as Gun;
		equippedGun.transform.parent = weaponHold;
		equippedGun.transform.localEulerAngles = new Vector3(0,180,0);
		equippedGun.tag = "bow";
	}
	
	public void Shoot() {
		if (equippedGun != null) {
			equippedGun.Shoot();
		}
	}
}